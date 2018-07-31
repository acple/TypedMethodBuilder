using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public interface Boxed<T>
    { }

    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>> Box<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => new IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>>(new OpType(OpCodes.Box, typeof(T)), il);

        public static IL<TParameter, TLocal, Stack<Ref<T>, TCallStack>> Unbox<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => new IL<TParameter, TLocal, Stack<Ref<T>, TCallStack>>(new OpType(OpCodes.Unbox, typeof(T)), il);

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Unbox_Any<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => new IL<TParameter, TLocal, Stack<T, TCallStack>>(new OpType(OpCodes.Unbox_Any, typeof(T)), il);

        public static IL<TParameter, TLocal, Stack<TTarget, TCallStack>> Unbox_Any<T, TTarget, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, TTarget witness)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<TTarget, TCallStack>>(new OpType(OpCodes.Unbox_Any, typeof(TTarget)), il);

        public static IL<TParameter, TLocal, Stack<TTarget, TCallStack>> Castclass<T, TTarget, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, TTarget witness)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : class
            where TTarget : class
            => new IL<TParameter, TLocal, Stack<TTarget, TCallStack>>(new OpType(OpCodes.Castclass, typeof(TTarget)), il);
    }
}
