namespace TypedMethodBuilder
{
    internal interface ILabel
    { }

    public class Label<TCallStack> : ILabel
        where TCallStack : ICallStack
    {
        internal Label()
        { }
    }
}
