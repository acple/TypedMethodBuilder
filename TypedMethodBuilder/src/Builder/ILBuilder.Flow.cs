using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    public static partial class ILBuilder
    {
        public static IL<TParameter, TLocal, Void> Ret<TParameter, TLocal>(this IL<TParameter, TLocal, Empty> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            => il.Next<TParameter, TLocal, Void>(new Op(OpCodes.Ret));

        public static IL<TParameter, TLocal, Void> Ret<T, TParameter, TLocal>(this IL<TParameter, TLocal, Stack<T, Empty>> il)
            where TParameter : ITypeList
            where TLocal : ITypeList
            => il.Next<TParameter, TLocal, Void>(new Op(OpCodes.Ret));

        public static IL<TParameter, TLocal, TCallStack> Bgt_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bgt_S, label));

        public static IL<TParameter, TLocal, TCallStack> Bgt_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bgt_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Bgt_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bgt_Un_S, label));

        public static IL<TParameter, TLocal, TCallStack> Bgt_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bgt_Un_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Bge_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bge_S, label));

        public static IL<TParameter, TLocal, TCallStack> Bge_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bge_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Bge_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bge_Un_S, label));

        public static IL<TParameter, TLocal, TCallStack> Bge_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bge_Un_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Blt_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Blt_S, label));

        public static IL<TParameter, TLocal, TCallStack> Blt_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Blt_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Blt_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Blt_Un_S, label));

        public static IL<TParameter, TLocal, TCallStack> Blt_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Blt_Un_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Ble_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Ble_S, label));

        public static IL<TParameter, TLocal, TCallStack> Ble_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Ble_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Ble_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Ble_Un_S, label));

        public static IL<TParameter, TLocal, TCallStack> Ble_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            where T : struct
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Ble_Un_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Beq_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Beq_S, label));

        public static IL<TParameter, TLocal, TCallStack> Beq_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Beq_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Bne_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Bne_Un_S, label));

        public static IL<TParameter, TLocal, TCallStack> Bne_Un_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, Stack<T, TCallStack>>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Bne_Un_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Br_S<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Br_S, label));

        public static IL<TParameter, TLocal, TCallStack> Br_S<TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, TCallStack> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Br_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Brfalse_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Brfalse_S, label));

        public static IL<TParameter, TLocal, TCallStack> Brfalse_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Brfalse_S, newLabel));

        public static IL<TParameter, TLocal, TCallStack> Brtrue_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, Label<TCallStack> label)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(new OpLabel(OpCodes.Brtrue_S, label));

        public static IL<TParameter, TLocal, TCallStack> Brtrue_S<T, TParameter, TLocal, TCallStack>(this IL<TParameter, TLocal, Stack<T, TCallStack>> il, out Label<TCallStack> newLabel)
            where TParameter : ITypeList
            where TLocal : ITypeList
            where TCallStack : ITypeList
            => il.Next<TParameter, TLocal, TCallStack>(newLabel = new Label<TCallStack>(), new OpLabel(OpCodes.Brtrue_S, newLabel));
    }
}
