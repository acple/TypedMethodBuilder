using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> Dup<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>>(new Op(OpCodes.Dup), il);

        public static IL<TParameter, TLocal, TCallStack> Pop<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new Op(OpCodes.Pop), il);
    }
}
