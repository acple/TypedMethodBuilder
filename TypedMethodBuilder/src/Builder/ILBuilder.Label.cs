namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, TCallStack> DefineLabel<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, out Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(label = new Label<TCallStack>(), il);

        public static IL<TParameter, TLocal, TCallStack> MarkLabel<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpMarkLabel(label), il);

        public static IL<TParameter, TLocal, TCallStack> MarkLabel<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
        {
            var next = il.DefineLabel(out newLabel);
            return new IL<TParameter, TLocal, TCallStack>(new OpMarkLabel(newLabel), next);
        }
    }
}
