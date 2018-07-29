namespace TypedMethodBuilder
{
    public interface ITypeList
    { }

    public interface Empty : ITypeList
    { }

    public interface Param<in T, TParameter> : ITypeList
        where TParameter : ITypeList
    { }

    public interface Local<T, TLocal> : ITypeList
        where TLocal : ITypeList
    { }

    public interface Stack<out T, TCallStack> : ITypeList
        where TCallStack : ITypeList
    { }
}
