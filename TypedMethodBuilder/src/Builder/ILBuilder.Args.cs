using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<Param<TThis, TParameter>, TLocal, Stack<TThis, TCallStack>> Ldarg_0<TThis, TParameter, TLocal, TCallStack>(this IL<Param<TThis, TParameter>, TLocal, TCallStack> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<Param<TThis, TParameter>, TLocal, Stack<TThis, TCallStack>>(new Op(OpCodes.Ldarg_0));

        public static IL<Param<TThis, Param<T, TParameter>>, TLocal, Stack<T, TCallStack>> Ldarg_1<TThis, T, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, TParameter>>, TLocal, TCallStack> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<Param<TThis, Param<T, TParameter>>, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Ldarg_1));

        public static IL<Param<TThis, Param<T, Param<T2, TParameter>>>, TLocal, Stack<T2, TCallStack>> Ldarg_2<TThis, T, T2, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, Param<T2, TParameter>>>, TLocal, TCallStack> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<Param<TThis, Param<T, Param<T2, TParameter>>>, TLocal, Stack<T2, TCallStack>>(new Op(OpCodes.Ldarg_2));

        public static IL<Param<TThis, Param<T, Param<T2, Param<T3, TParameter>>>>, TLocal, Stack<T3, TCallStack>> Ldarg_3<TThis, T, T2, T3, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, TParameter>>>>, TLocal, TCallStack> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<Param<TThis, Param<T, Param<T2, Param<T3, TParameter>>>>, TLocal, Stack<T3, TCallStack>>(new Op(OpCodes.Ldarg_3));

        public static IL<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, TParameter>>>>>, TLocal, Stack<T4, TCallStack>> Ldarg_4<TThis, T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, TParameter>>>>>, TLocal, TCallStack> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, TParameter>>>>>, TLocal, Stack<T4, TCallStack>>(new OpIndex_S(OpCodes.Ldarg_S, 4));
    }
}
