using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Box<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Box), il);

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Unbox<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Unbox), il);

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Unbox_Any<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new Op(OpCodes.Unbox_Any), il);
    }
}
