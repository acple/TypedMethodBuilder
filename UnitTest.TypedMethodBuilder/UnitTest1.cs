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
                .LdLoc_1()
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
                .Concat(Enumerable.Repeat(new Random("seed".GetHashCode()), 10000).Select(x => x.Next()))
                .Select(x => (x, func: IL<object>.MethodBuilder().Ldc_I4(x).Build()));

            foreach (var (value, func) in source)
                func.Invoke().Is(value);
        }
    }
}
