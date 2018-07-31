using System;
using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, TCallStack> Call<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, Action function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Call<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, Action<T> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Call<T, T2, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T2, Stack<T, TCallStack>>> il, Action<T, T2> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Call<T, T2, T3, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T3, Stack<T2, Stack<T, TCallStack>>>> il, Action<T, T2, T3> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Call<T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T4, Stack<T3, Stack<T2, Stack<T, TCallStack>>>>> il, Action<T, T2, T3, T4> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Call<TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, Func<TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Call<T, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, Func<T, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Call<T, T2, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T2, Stack<T, TCallStack>>> il, Func<T, T2, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Call<T, T2, T3, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T3, Stack<T2, Stack<T, TCallStack>>>> il, Func<T, T2, T3, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Call<T, T2, T3, T4, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T4, Stack<T3, Stack<T2, Stack<T, TCallStack>>>>> il, Func<T, T2, T3, T4, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);
    }

    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, TCallStack> CallInstance<TInstance, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<TInstance, TCallStack>> il, Action function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> CallInstance<TInstance, T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<TInstance, TCallStack>>> il, Action<T> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> CallInstance<TInstance, T, T2, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>> il, Action<T, T2> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> CallInstance<TInstance, T, T2, T3, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>> il, Action<T, T2, T3> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> CallInstance<TInstance, T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T4, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>>> il, Action<T, T2, T3, T4> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> CallInstance<TInstance, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<TInstance, TCallStack>> il, Func<TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> CallInstance<TInstance, T, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<TInstance, TCallStack>>> il, Func<T, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> CallInstance<TInstance, T, T2, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>> il, Func<T, T2, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> CallInstance<TInstance, T, T2, T3, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>> il, Func<T, T2, T3, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> CallInstance<TInstance, T, T2, T3, T4, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T4, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>>> il, Func<T, T2, T3, T4, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(function.Method), il);
    }

    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, TCallStack> Callvirt<TInstance, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<TInstance, TCallStack>> il, Action function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Callvirt<TInstance, T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<TInstance, TCallStack>>> il, Action<T> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Callvirt<TInstance, T, T2, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>> il, Action<T, T2> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Callvirt<TInstance, T, T2, T3, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>> il, Action<T, T2, T3> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, TCallStack> Callvirt<TInstance, T, T2, T3, T4, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T4, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>>> il, Action<T, T2, T3, T4> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, TCallStack>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Callvirt<TInstance, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<TInstance, TCallStack>> il, Func<TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Callvirt<TInstance, T, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<TInstance, TCallStack>>> il, Func<T, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Callvirt<TInstance, T, T2, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>> il, Func<T, T2, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Callvirt<TInstance, T, T2, T3, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>> il, Func<T, T2, T3, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(OpCodes.Callvirt, function.Method), il);

        public static IL<TParameter, TLocal, Stack<TResult, TCallStack>> Callvirt<TInstance, T, T2, T3, T4, TResult, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T4, Stack<T3, Stack<T2, Stack<T, Stack<TInstance, TCallStack>>>>>> il, Func<T, T2, T3, T4, TResult> function)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where TInstance : class
            => new IL<TParameter, TLocal, Stack<TResult, TCallStack>>(new OpCall(OpCodes.Callvirt, function.Method), il);
    }
}
