namespace TypedMethodBuilder
{
    public interface Void
    { }

    public interface IParameter
    { }

    public interface ILocalVariable
    { }

    public interface ICallStack
    { }

    public interface Empty : IParameter, ILocalVariable, ICallStack
    { }

    public interface Param<in T, TParameter> : IParameter
        where TParameter : IParameter
    { }

    public interface Local<T, TLocal> : ILocalVariable
        where TLocal : ILocalVariable
    { }

    public interface Stack<out T, TCallStack> : ICallStack
        where TCallStack : ICallStack
    { }
}
