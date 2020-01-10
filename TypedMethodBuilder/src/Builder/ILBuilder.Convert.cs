using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<sbyte, TCallStack>> Conv_I1<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<sbyte, TCallStack>>(new Op(OpCodes.Conv_I1));

        public static IL<TParameter, TLocal, Stack<short, TCallStack>> Conv_I2<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<short, TCallStack>>(new Op(OpCodes.Conv_I2));

        public static IL<TParameter, TLocal, Stack<int, TCallStack>> Conv_I4<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<int, TCallStack>>(new Op(OpCodes.Conv_I4));

        public static IL<TParameter, TLocal, Stack<long, TCallStack>> Conv_I8<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<long, TCallStack>>(new Op(OpCodes.Conv_I8));
    }

    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<byte, TCallStack>> Conv_U1<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<byte, TCallStack>>(new Op(OpCodes.Conv_U1));

        public static IL<TParameter, TLocal, Stack<ushort, TCallStack>> Conv_U2<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<ushort, TCallStack>>(new Op(OpCodes.Conv_U2));

        public static IL<TParameter, TLocal, Stack<uint, TCallStack>> Conv_U4<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<uint, TCallStack>>(new Op(OpCodes.Conv_U4));

        public static IL<TParameter, TLocal, Stack<ulong, TCallStack>> Conv_U8<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<ulong, TCallStack>>(new Op(OpCodes.Conv_U8));
    }
}
