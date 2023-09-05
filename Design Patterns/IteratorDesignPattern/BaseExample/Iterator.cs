using System.Collections;

namespace IteratorDesignPattern.BaseExample
{
    internal abstract class Iterator : IEnumerator
    {
        public object Current => GetCurrent();

        public abstract int Key();

        public abstract object GetCurrent();

        public abstract bool MoveNext();

        public abstract void Reset();
    }
}
