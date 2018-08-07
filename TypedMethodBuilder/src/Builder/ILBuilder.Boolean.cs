using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<T, TCallStack>> And<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.And));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Or<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Or));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Neg<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Neg));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Not<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Not));

        public static IL<TParameter, TLocal, Stack<bool, TCallStack>> Ceq<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, Stack<bool, TCallStack>>(new Op(OpCodes.Ceq));

        public static IL<TParameter, TLocal, Stack<bool, TCallStack>> Cgt<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<bool, TCallStack>>(new Op(OpCodes.Cgt));

        public static IL<TParameter, TLocal, Stack<bool, TCallStack>> Cgt_Un<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<bool, TCallStack>>(new Op(OpCodes.Cgt_Un));

        public static IL<TParameter, TLocal, Stack<bool, TCallStack>> Clt<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<bool, TCallStack>>(new Op(OpCodes.Clt));

        public static IL<TParameter, TLocal, Stack<bool, TCallStack>> Clt_Un<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, Stack<bool, TCallStack>>(new Op(OpCodes.Clt_Un));
    }
}
