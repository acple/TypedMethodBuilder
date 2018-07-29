using System;
using System.Reflection.Emit;
using TypedMethodBuilder;
using Xunit;

namespace UnitTest.TypedMethodBuilder
{
    public class UnitTest1
    {
        [Fact]
        public void PrintfDebug()
        {
            var instance = this;

            var f = IL<UnitTest1>.MethodBuilder<int, string, double, DateTime>()
                .Ldarg_2()
                .Stloc_0()
                .Ldloc_0()
                .Call(UnitTest1.Y)

                .Ldnull(default(object))
                .Ldarg_4()
                .Stloc_1()
                .Ldarg_3()
                .CallInstance(x => Console.WriteLine(x))

                .Ldloc_0()
                .Ldarg_2()
                .LdLoc_1()
                .CallInstance((x, y) => ($"{x.GetType()} {y.GetType()}"))
                // .Pop()

                .Ldarg_3()
                .Ldarg_3()
                .Add()
                .Pop()
                .Build(null);

            var xxx = f.Invoke(7, "abcd", 99.9, DateTime.Now);
            Console.WriteLine(xxx);
        }

        private void X(string a)
            => Console.WriteLine(a + a);

        private static void Y(string a)
            => Console.WriteLine(a + a + a);
    }
}
