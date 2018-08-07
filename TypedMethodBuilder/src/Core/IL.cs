using System.Collections;
using System.Collections.Generic;

namespace TypedMethodBuilder
{
    internal interface IIL
    {
        Stack<Op> Ops { get; }

        Stack<ILabel> Labels { get; }
    }

    public readonly struct IL<TParameter, TLocal, TCallStack> : IIL
    {
        internal static IL<TParameter, TLocal, TCallStack> New => new IL<TParameter, TLocal, TCallStack>(Stack<Op>.Empty, Stack<ILabel>.Empty);

        private readonly Stack<Op> _ops;

        private readonly Stack<ILabel> _labels;

        Stack<Op> IIL.Ops => this._ops;

        Stack<ILabel> IIL.Labels => this._labels;

        private IL(Stack<Op> ops, Stack<ILabel> labels)
        {
            this._ops = ops;
            this._labels = labels;
        }

        internal IL<TParamNext, TLocalNext, TStackNext> Next<TParamNext, TLocalNext, TStackNext>(Op op)
            => new IL<TParamNext, TLocalNext, TStackNext>(this._ops.Add(op), this._labels);

        internal IL<TParamNext, TLocalNext, TStackNext> Next<TParamNext, TLocalNext, TStackNext>(ILabel label)
            => new IL<TParamNext, TLocalNext, TStackNext>(this._ops, this._labels.Add(label));

        internal IL<TParamNext, TLocalNext, TStackNext> Next<TParamNext, TLocalNext, TStackNext>(ILabel label, Op op)
            => new IL<TParamNext, TLocalNext, TStackNext>(this._ops.Add(op), this._labels.Add(label));
    }
}
