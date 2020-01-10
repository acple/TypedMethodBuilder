using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public interface Ref<T>
    { }

    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Stack<T, TCallStack>> Ldobj<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<Ref<T>, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, TLocal, Stack<T, TCallStack>>(new OpType(OpCodes.Ldobj, typeof(T)));
    }

    public static partial class ILBuilder
    {
        public static IL<Param<TThis, TParameter>, TLocal, Stack<Ref<TThis>, TCallStack>> Ldarga_0<TThis, TParameter, TLocal, TCallStack>(this IL<Param<TThis, TParameter>, TLocal, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<Param<TThis, TParameter>, TLocal, Stack<Ref<TThis>, TCallStack>>(new OpIndex_S(OpCodes.Ldarga_S, 0));

        public static IL<Param<TThis, Param<T, TParameter>>, TLocal, Stack<Ref<T>, TCallStack>> Ldarga_1<TThis, T, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, TParameter>>, TLocal, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<Param<TThis, Param<T, TParameter>>, TLocal, Stack<Ref<T>, TCallStack>>(new OpIndex_S(OpCodes.Ldarga_S, 1));

        public static IL<Param<TThis, Param<T, Param<T2, TParameter>>>, TLocal, Stack<Ref<T2>, TCallStack>> Ldarga_2<TThis, T, T2, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, Param<T2, TParameter>>>, TLocal, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<Param<TThis, Param<T, Param<T2, TParameter>>>, TLocal, Stack<Ref<T2>, TCallStack>>(new OpIndex_S(OpCodes.Ldarga_S, 2));

        public static IL<Param<TThis, Param<T, Param<T2, Param<T3, TParameter>>>>, TLocal, Stack<Ref<T3>, TCallStack>> Ldarga_3<TThis, T, T2, T3, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, TParameter>>>>, TLocal, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<Param<TThis, Param<T, Param<T2, Param<T3, TParameter>>>>, TLocal, Stack<Ref<T3>, TCallStack>>(new OpIndex_S(OpCodes.Ldarga_S, 3));

        public static IL<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, TParameter>>>>>, TLocal, Stack<Ref<T4>, TCallStack>> Ldarga_4<TThis, T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, TParameter>>>>>, TLocal, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<Param<TThis, Param<T, Param<T2, Param<T3, Param<T4, TParameter>>>>>, TLocal, Stack<Ref<T4>, TCallStack>>(new OpIndex_S(OpCodes.Ldarga_S, 4));
    }

    public static partial class ILBuilder
    {
        public static IL<TParameter, Local<T, TLocal>, Stack<Ref<T>, TCallStack>> Ldloca_0<T, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, TLocal>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, TLocal>, Stack<Ref<T>, TCallStack>>(new OpIndex_S(OpCodes.Ldloca_S, 0));

        public static IL<TParameter, Local<T, Local<T2, TLocal>>, Stack<Ref<T2>, TCallStack>> Ldloca_1<T, T2, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, TLocal>>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, TLocal>>, Stack<Ref<T2>, TCallStack>>(new OpIndex_S(OpCodes.Ldloca_S, 1));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, Stack<Ref<T3>, TCallStack>> Ldloca_2<T, T2, T3, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, Stack<Ref<T3>, TCallStack>>(new OpIndex_S(OpCodes.Ldloca_S, 2));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, Stack<Ref<T4>, TCallStack>> Ldloca_3<T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, Stack<Ref<T4>, TCallStack>>(new OpIndex_S(OpCodes.Ldloca_S, 3));
    }
}
