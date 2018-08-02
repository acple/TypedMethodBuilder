using System;
using System.Reflection;
using System.Reflection.Emit;

namespace TypedMethodBuilder
{
    internal class Op
    {
        public static Op Nop { get; } = new Op(OpCodes.Nop);

        public OpCode OpCode { get; }

        public Op(OpCode opCode)
        {
            this.OpCode = opCode;
        }

        public virtual void Emit(ILGenerator generator)
            => generator.Emit(this.OpCode);

        public override string ToString()
            => this.OpCode.ToString();
    }

    internal class OpCall : Op
    {
        private readonly MethodInfo _method;

        public OpCall(MethodInfo method) : this(OpCodes.Call, method)
        { }

        public OpCall(OpCode opCode, MethodInfo method) : base(opCode)
        {
            this._method = method;
        }

        public override void Emit(ILGenerator generator)
            => generator.EmitCall(this.OpCode, this._method, null);
    }

    internal class OpType : Op
    {
        private readonly Type _type;

        public OpType(OpCode opCode, Type type) : base(opCode)
        {
            this._type = type;
        }

        public override void Emit(ILGenerator generator)
            => generator.Emit(this.OpCode, this._type);
    }

    internal class OpIndex_S : Op
    {
        private readonly byte _index;

        public OpIndex_S(OpCode opCode, byte index) : base(opCode)
        {
            this._index = index;
        }

        public override void Emit(ILGenerator generator)
            => generator.Emit(this.OpCode, this._index);
    }

    internal class OpLdc_I4 : Op
    {
        private readonly int _value;

        public OpLdc_I4(int value) : base(OpCodes.Nop)
        {
            this._value = value;
        }

        public override void Emit(ILGenerator generator)
        {
            var value = this._value;

            switch (value)
            {
                case -1: generator.Emit(OpCodes.Ldc_I4_M1); return;
                case 0: generator.Emit(OpCodes.Ldc_I4_0); return;
                case 1: generator.Emit(OpCodes.Ldc_I4_1); return;
                case 2: generator.Emit(OpCodes.Ldc_I4_2); return;
                case 3: generator.Emit(OpCodes.Ldc_I4_3); return;
                case 4: generator.Emit(OpCodes.Ldc_I4_4); return;
                case 5: generator.Emit(OpCodes.Ldc_I4_5); return;
                case 6: generator.Emit(OpCodes.Ldc_I4_6); return;
                case 7: generator.Emit(OpCodes.Ldc_I4_7); return;
                case 8: generator.Emit(OpCodes.Ldc_I4_8); return;
            }

            if ((sbyte)value == value)
                generator.Emit(OpCodes.Ldc_I4_S, (byte)value);
            else
                generator.Emit(OpCodes.Ldc_I4, value);
        }
    }

    internal class OpDeclareLocal : Op
    {
        private readonly Type _type;

        public OpDeclareLocal(Type type, OpCode opCode) : base(opCode)
        {
            this._type = type;
        }

        public override void Emit(ILGenerator generator)
        {
            generator.DeclareLocal(this._type);
            generator.Emit(this.OpCode);
        }
    }
}
