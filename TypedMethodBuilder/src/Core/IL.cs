using System.Collections;
using System.Collections.Generic;

namespace TypedMethodBuilder
{
    internal interface IStack<T> : IEnumerable<T>
    {
        T Value { get; }

        IStack<T> Parent { get; }
    }

    public class IL<TParameter, TLocal, TCallStack> : IStack<Op>
        where TParameter : ITypeList
        where TLocal : ITypeList
        where TCallStack : ITypeList
    {
        private readonly Op _op;

        private readonly IStack<Op> _parent;

        Op IStack<Op>.Value => this._op;

        IStack<Op> IStack<Op>.Parent => this._parent;

        internal IL() : this(Op.Nop, null)
        { }

        internal IL(Op op, IStack<Op> parent)
        {
            this._op = op;
            this._parent = parent;
        }

        IEnumerator<Op> IEnumerable<Op>.GetEnumerator()
        {
            for (var stack = this as IStack<Op>; stack.Parent != null; stack = stack.Parent)
                yield return stack.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => (this as IEnumerable<Op>).GetEnumerator();
    }
}
