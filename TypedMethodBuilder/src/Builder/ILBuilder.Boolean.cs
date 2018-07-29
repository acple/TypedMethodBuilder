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
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.And), il);

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Or<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Or), il);

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Neg<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Neg), il);

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Not<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Not), il);
    }
}
