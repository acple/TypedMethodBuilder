using System.Collections;
using System.Collections.Generic;

namespace TypedMethodBuilder
{
    internal interface IIL
    {
        Stack<Op> Ops { get; }

        Stack<ILabel> Labels { get; }
    }

    public class IL<TParameter, TLocal, TCallStack> : IIL
    {
        private readonly Stack<Op> _ops;

        private readonly Stack<ILabel> _labels;

        Stack<Op> IIL.Ops => this._ops;

        Stack<ILabel> IIL.Labels => this._labels;

        internal IL() : this(Stack<Op>.Empty, Stack<ILabel>.Empty)
        { }

        internal IL(Op op, IIL parent) : this(parent.Ops.Add(op), parent.Labels)
        { }

        internal IL(ILabel label, IIL parent) : this(parent.Ops, parent.Labels.Add(label))
        { }

        internal IL(ILabel label, Op op, IIL parent) : this(parent.Ops.Add(op), parent.Labels.Add(label))
        { }

        private IL(Stack<Op> ops, Stack<ILabel> labels)
        {
            this._ops = ops;
            this._labels = labels;
        }
    }
}
