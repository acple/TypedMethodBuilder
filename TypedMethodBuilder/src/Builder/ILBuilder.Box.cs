using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public interface Boxed<T>
    { }

    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>> Box<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<Boxed<T>, TCallStack>>(new OpType(OpCodes.Box, typeof(T)));

        public static IL<TParameter, TLocal, Stack<Ref<T>, TCallStack>> Unbox<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<Ref<T>, TCallStack>>(new OpType(OpCodes.Unbox, typeof(T)));

        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Unbox_Any<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<Boxed<T>, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : struct
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new OpType(OpCodes.Unbox_Any, typeof(T)));

        public static IL<TParameter, TLocal, Stack<TTarget, TCallStack>> Unbox_Any<T, TTarget, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, TTarget witness)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, TLocal, Stack<TTarget, TCallStack>>(new OpType(OpCodes.Unbox_Any, typeof(TTarget)));

        public static IL<TParameter, TLocal, Stack<TTarget, TCallStack>> Castclass<T, TTarget, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, TTarget witness)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            where T : class
            where TTarget : class
            => il.Next<TParameter, TLocal, Stack<TTarget, TCallStack>>(new OpType(OpCodes.Castclass, typeof(TTarget)));
    }
}
