using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Void> Ret<TParameter, TLocal>(this IL<TParameter, TLocal, Empty> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            => new IL<TParameter, TLocal, Void>(new Op(OpCodes.Ret), il);

        public static IL<TParameter, TLocal, Void> Ret<T, TParameter, TLocal>(this IL<TParameter, TLocal, Stack<T, Empty>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            => new IL<TParameter, TLocal, Void>(new Op(OpCodes.Ret), il);

        public static IL<TParameter, TLocal, TCallStack> Bgt_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bgt_S, label), il);

        public static IL<TParameter, TLocal, TCallStack> Bgt_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bgt_S, newLabel), il);

        public static IL<TParameter, TLocal, TCallStack> Bge_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bge_S, label), il);

        public static IL<TParameter, TLocal, TCallStack> Bge_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bge_S, newLabel), il);
    }
}
