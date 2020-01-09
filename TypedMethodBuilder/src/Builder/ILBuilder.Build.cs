using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static Action Build<TThis, TLocal>(this IL<Param<TThis, Empty>, TLocal, Empty> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Action>(il, target, null, typeof(TThis));

        public static Action<T> Build<TThis, T, TLocal>(this IL<Param<TThis, Param<T, Empty>>, TLocal, Empty> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Action<T>>(il, target, null, typeof(TThis), typeof(T));

        public static Action<T, T2> Build<TThis, T, T2, TLocal>(this IL<Param<TThis, Param<T, Param<T2, Empty>>>, TLocal, Empty> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Action<T, T2>>(il, target, null, typeof(TThis), typeof(T), typeof(T2));

        public static Action<T, T2, T3> Build<TThis, T, T2, T3, TLocal>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, Empty>>>>, TLocal, Empty> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Action<T, T2, T3>>(il, target, null, typeof(TThis), typeof(T), typeof(T2), typeof(T3));

        public static Action<T, T2, T3, T4> Build<TThis, T, T2, T3, T4, TLocal>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, TLocal, Empty> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Action<T, T2, T3, T4>>(il, target, null, typeof(TThis), typeof(T), typeof(T2), typeof(T3), typeof(T4));

        public static Func<TResult> Build<TThis, TResult, TLocal>(this IL<Param<TThis, Empty>, TLocal, Stack<TResult, Empty>> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Func<TResult>>(il, target, typeof(TResult), typeof(TThis));

        public static Func<T, TResult> Build<TThis, T, TResult, TLocal>(this IL<Param<TThis, Param<T, Empty>>, TLocal, Stack<TResult, Empty>> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Func<T, TResult>>(il, target, typeof(TResult), typeof(TThis), typeof(T));

        public static Func<T, T2, TResult> Build<TThis, T, T2, TResult, TLocal>(this IL<Param<TThis, Param<T, Param<T2, Empty>>>, TLocal, Stack<TResult, Empty>> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Func<T, T2, TResult>>(il, target, typeof(TResult), typeof(TThis), typeof(T), typeof(T2));

        public static Func<T, T2, T3, TResult> Build<TThis, T, T2, T3, TResult, TLocal>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, Empty>>>>, TLocal, Stack<TResult, Empty>> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Func<T, T2, T3, TResult>>(il, target, typeof(TResult), typeof(TThis), typeof(T), typeof(T2), typeof(T3));

        public static Func<T, T2, T3, T4, TResult> Build<TThis, T, T2, T3, T4, TResult, TLocal>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, Empty>>>>>, TLocal, Stack<TResult, Empty>> il, TThis? target = null)
            where TLocal : ITypeList
            where TThis : class
            => Build<Func<T, T2, T3, T4, TResult>>(il, target, typeof(TResult), typeof(TThis), typeof(T), typeof(T2), typeof(T3), typeof(T4));

        private static TDelegate Build<TDelegate>(IIL il, object? target, Type? returnType, params Type[] parameters)
            where TDelegate : Delegate
        {
            var method = new DynamicMethod(
                Guid.NewGuid().ToString(),
                returnType,
                parameters,
                restrictedSkipVisibility: true);

            var generator = method.GetILGenerator();
            var labels = il.Labels.Reverse().ToDictionary(x => x, _ => generator.DefineLabel());

            foreach (var op in il.Ops.Reverse())
                op.Emit(generator, labels);

            generator.Emit(OpCodes.Ret);

            return (TDelegate)method.CreateDelegate(typeof(TDelegate), target);
        }
    }
}
