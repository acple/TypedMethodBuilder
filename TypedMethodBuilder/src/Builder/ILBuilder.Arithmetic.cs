using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Add<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Add));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Add_Ovf<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Add_Ovf));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Add_Ovf_Un<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Add_Ovf_Un));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Mul<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Mul));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Mul_Ovf<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Mul_Ovf));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Mul_Ovf_Un<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Mul_Ovf_Un));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Div<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Div));

        public static IL<TParameter, TLocal, Stack<int, TCallStack>> Div_Un<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<int, TCallStack>>(new Op(OpCodes.Div_Un));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Sub<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Sub));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Sub_Ovf<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Sub_Ovf));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Sub_Ovf_Un<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Sub_Ovf_Un));
    }
}
