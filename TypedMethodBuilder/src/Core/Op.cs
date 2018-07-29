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

    internal class OpLdarg : Op
    {
        private readonly int _index;

        public OpLdarg(int index) : base(OpCodes.Ldarg_S)
        {
            this._index = index;
        }

        public override void Emit(ILGenerator generator)
            => generator.Emit(this.OpCode, (byte)this._index);
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
