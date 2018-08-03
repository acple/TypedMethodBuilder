using System.Collections;
using System.Collections.Generic;

namespace TypedMethodBuilder
{
    internal interface IL
    {
        Stack<Op> Ops { get; }

        Stack<ILabel> Labels { get; }
    }

    public class IL<TParameter, TLocal, TCallStack> : IL
    {
        private readonly Stack<Op> _ops;

        private readonly Stack<ILabel> _labels;

        Stack<Op> IL.Ops => this._ops;

        Stack<ILabel> IL.Labels => this._labels;

        internal IL() : this(Stack<Op>.Empty, Stack<ILabel>.Empty)
        { }

        internal IL(Op op, IL parent) : this(parent.Ops.Add(op), parent.Labels)
        { }

        internal IL(ILabel label, IL parent) : this(parent.Ops, parent.Labels.Add(label))
        { }

        internal IL(ILabel label, Op op, IL parent) : this(parent.Ops.Add(op), parent.Labels.Add(label))
        { }

        private IL(Stack<Op> ops, Stack<ILabel> labels)
        {
            this._ops = ops;
            this._labels = labels;
        }
    }
}
