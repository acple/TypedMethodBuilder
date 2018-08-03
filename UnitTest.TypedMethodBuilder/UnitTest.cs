using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using ChainingAssertion;
using TypedMethodBuilder;
using Xunit;

namespace UnitTest.TypedMethodBuilder
{
    public class UnitTest
    {
        [Fact]
        public void PrintfDebug()
        {
            var instance = this;

            var f = IL<UnitTest>.MethodBuilder<int, string, double, DateTime>()
                .Ldarg_2()
                .Stloc_0()
                .Ldloc_0()
                .Call(Function)

                .Ldnull(default(object))
                .Ldarg_4()
                .Stloc_1()
                .Ldarg_3()
                .CallInstance(x => Console.WriteLine(x))

                .Ldloc_0()
                .Ldarg_2()
                .Ldloc_1()
                .CallInstance((x, y) => ($"{x.GetType()}, {y.GetType()}"))
                // .Pop()

                .Ldarg_3()
                .Ldarg_3()
                .Add()
                .Pop()

                .Build(instance);

            var result = f.Invoke(7, "abcd", 99.9, DateTime.Now);
            result.Is("System.String, System.DateTime");
        }
        private static void Function(string x)
        { }

        [Fact]
        public void Example()
        {
            var instance = this;

            var f = IL<UnitTest> // an instance type
                .MethodBuilder<int, string>() // define parameters. (int, string) => { ? }
                .Ldarg_2() // load parameter. stack: [ string ]
                .Call(int.Parse) // call static method. stack: [ string ] => [ int ]
                .Ldarg_1() // load parameter. stack: [ int, int ]
                .Add() // add two int. stack: [ int, int ] => [ int ]
                .Call((Action<int>)Console.WriteLine) // call static method, type annotation with cast expression. stack: [ int ] => []
                .Ldarg_0() // load 'this'. stack: [] => [ MyClass ]
                .CallInstance(instance.MyFunc) // call instance method. stack: [ MyClass ] => [ IEnumerable<string> ]

                // .Pop() // <- if you uncomment this, callstack is popped, the Build() result type is Action<int, string> !

                .Build(instance); // create delegate, the delegate type is Func<int, string, IEnumerable<string>>

            var result = f.Invoke(123, "456");

            result.Is("abc", "def", "ghi");
        }

        private IEnumerable<string> MyFunc()
            => new[] { "abc", "def", "ghi" };

        [Fact]
        public void Ldc_I4Test()
        {
            var source = Enumerable.Range(-1, 100)
                .Concat(Enumerable.Repeat(new Random("seed".GetHashCode()), 10000).Select(x => x.Next(int.MinValue, int.MaxValue)))
                .Select(x => (x, func: IL.MethodBuilder().Ldc_I4(x).Build()));

            foreach (var (value, func) in source)
                func.Invoke().Is(value);
        }

        [Fact]
        public void BoxTest()
        {
            {
                var func = IL.MethodBuilder<int>()
                    .Ldarg_1()
                    .Box()
                    .Callvirt((Func<string>)new object().ToString)
                    .Build();

                func.Invoke(1234).Is("1234");
            }

            {
                var func = IL<object>.MethodBuilder<int>()
                    .Ldarg_1()
                    .Stloc_0()
                    .Ldloc_0()
                    .Box()
                    .Stloc_1()
                    .Ldloc_1()
                    .Unbox_Any()
                    .Ldloc_0()
                    .Add()
                    .Build();

                var source = Enumerable.Repeat(new Random("test".GetHashCode()), 10000)
                    .Select(x => x.Next(int.MinValue, int.MaxValue));
                foreach (var x in source)
                    func.Invoke(x).Is(x + x);
            }

            {
                var func = IL.MethodBuilder()
                    .Ldnull(null as object)
                    .CallInstance(() => new DateTime(2018, 8, 1))
                    .Box().Unbox() // it's ref
                    .Ldc_I4(100)
                    .CallInstance(default(DateTime).AddYears)
                    .Build();

                func.Invoke().Is(new DateTime(2118, 8, 1));
            }
        }

        [Fact]
        public void RefTest()
        {
            {
                var func = IL.MethodBuilder<int>()
                    .Ldarga_1()
                    .CallInstance((Func<string>)default(int).ToString)
                    .Build();

                foreach (var x in Enumerable.Range(-100, 65535))
                    func.Invoke(x).Is(x.ToString());
            }

            {
                var func = IL.MethodBuilder<DateTime>()
                    .Ldarga_1()
                    .Ldc_I4(100)
                    .CallInstance(default(DateTime).AddYears)
                    .Build();

                var source = Enumerable.Repeat(new Random("date".GetHashCode()), 1000)
                    .Select(x => (long)x.Next())
                    .Select(x => new DateTime(x));
                foreach (var x in source)
                    func.Invoke(x).Is(x.AddYears(100));
            }
        }

        [Fact]
        public void LabelTest()
        {
            {
                var func = IL.MethodBuilder<int, int>() // (x, y) => !(x > y) ? x : y;
                    .Ldarg_1()
                    .Ldarg_2()
                    .Bgt_S(out var ifArg1IsGreaterThanArg2)
                    .Ldarg_1()
                    .Ret()
                    .MarkLabel(ifArg1IsGreaterThanArg2)
                    .Ldarg_2()
                    .Build();

                func.Invoke(2, 4).Is(2);
                func.Invoke(9, 6).Is(6);
            }

            {
                var func = IL.MethodBuilder<int, int>()
                    .Ldarg_1().Dup().Dup().Dup().Dup() // deep stack
                    .Ldarg_2()
                    .Bge_S(out var label)
                    .Pop().Pop().Pop()
                    .Ret()
                    .MarkLabel(label)
                    .Add().Add().Add()
                    .Build();

                func.Invoke(2, 3).Is(2);
                func.Invoke(3, 3).Is(12);
            }

            {
                var func = IL.MethodBuilder<int, int>()
                    .Ldc_I4(0) // counter on stack

                    .Ldarg_1().Stloc_0() // loc0 = arg1

                    .MarkLabel(out var loop)

                    .Ldc_I4(1).Add() // counter++

                    .Ldloc_0()
                    .Ldarg_2()
                    .Sub()
                    .Stloc_0() // loc0 -= arg2

                    .Ldloc_0()
                    .Ldc_I4(0)
                    .Bgt_S(loop) // loc0 > 0

                    .Build(); // return counter

                func.Invoke(100, 5).Is(20);
                func.Invoke(81, 9).Is(9);
            }
        }
    }
}
