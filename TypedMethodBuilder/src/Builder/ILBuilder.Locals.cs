using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, Local<T, Empty>, TCallStack> Stloc_0<T, TParameter, TCallStack>(this IL<TParameter, Empty, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Empty>, TCallStack>(new OpDeclareLocal(typeof(T), OpCodes.Stloc_0));

        public static IL<TParameter, Local<T, TLocal>, TCallStack> Stloc_0<T, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, TLocal>, Stack<T, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, TLocal>, TCallStack>(new Op(OpCodes.Stloc_0));

        public static IL<TParameter, Local<T, Local<T2, Empty>>, TCallStack> Stloc_1<T, T2, TParameter, TCallStack>(this IL<TParameter, Local<T, Empty>, Stack<T2, TCallStack>> il)
            where TParameter : IParameter
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Empty>>, TCallStack>(new OpDeclareLocal(typeof(T2), OpCodes.Stloc_1));

        public static IL<TParameter, Local<T, Local<T2, TLocal>>, TCallStack> Stloc_1<T, T2, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, TLocal>>, Stack<T2, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, TLocal>>, TCallStack>(new Op(OpCodes.Stloc_1));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, Empty>>>, TCallStack> Stloc_2<T, T2, T3, TParameter, TCallStack>(this IL<TParameter, Local<T, Local<T2, Empty>>, Stack<T3, TCallStack>> il)
            where TParameter : IParameter
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, Empty>>>, TCallStack>(new OpDeclareLocal(typeof(T3), OpCodes.Stloc_2));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, TCallStack> Stloc_2<T, T2, T3, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, Stack<T3, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, TCallStack>(new Op(OpCodes.Stloc_2));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, Empty>>>>, TCallStack> Stloc_3<T, T2, T3, T4, TParameter, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, Empty>>>, Stack<T4, TCallStack>> il)
            where TParameter : IParameter
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, Local<T4, Empty>>>>, TCallStack>(new OpDeclareLocal(typeof(T4), OpCodes.Stloc_3));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, TCallStack> Stloc_3<T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, Stack<T4, TCallStack>> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, TCallStack>(new Op(OpCodes.Stloc_3));

        public static IL<TParameter, Local<T, TLocal>, Stack<T, TCallStack>> Ldloc_0<T, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, TLocal>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, TLocal>, Stack<T, TCallStack>>(new Op(OpCodes.Ldloc_0));

        public static IL<TParameter, Local<T, Local<T2, TLocal>>, Stack<T2, TCallStack>> Ldloc_1<T, T2, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, TLocal>>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, TLocal>>, Stack<T2, TCallStack>>(new Op(OpCodes.Ldloc_1));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, Stack<T3, TCallStack>> Ldloc_2<T, T2, T3, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, TLocal>>>, Stack<T3, TCallStack>>(new Op(OpCodes.Ldloc_2));

        public static IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, Stack<T4, TCallStack>> Ldloc_3<T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, TCallStack> il)
            where TParameter : IParameter
            where TLocal : ILocalVariable
            where TCallStack : ICallStack
            => il.Next<TParameter, Local<T, Local<T2, Local<T3, Local<T4, TLocal>>>>, Stack<T4, TCallStack>>(new Op(OpCodes.Ldloc_3));
    }
}
