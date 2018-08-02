using System.Collections;
using System.Collections.Generic;

namespace TypedMethodBuilder
{
    internal class Stack<T> : IReadOnlyCollection<T>
    {
        public static Stack<T> Empty { get; } = new Stack<T>();

        public T Value { get; }

        public Stack<T> Next { get; }

        public int Count { get; }

        private Stack()
        {
            this.Next = this;
        }

        private Stack(T value, Stack<T> parent)
        {
            this.Value = value;
            this.Next = parent;
            this.Count = parent.Count + 1;
        }

        public Stack<T> Add(T value)
            => new Stack<T>(value, this);

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = this; current != current.Next; current = current.Next)
                yield return current.Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}
