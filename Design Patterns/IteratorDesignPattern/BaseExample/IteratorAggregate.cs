using System.Collections;

namespace IteratorDesignPattern.BaseExample
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
