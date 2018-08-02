namespace TypedMethodBuilder
{
    internal interface ILabel
    { }

    public class Label<TCallStack> : ILabel
        where TCallStack : ITypeList
    {
        internal Label()
        { }
    }
}
