using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Ldnull<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, T witness)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : class
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Ldnull));

        public static IL<TParameter, TLocal, Stack<int, TCallStack>> Ldc_I4<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, int value)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, Stack<int, TCallStack>>(new OpLdc_I4(value));
    }
}
