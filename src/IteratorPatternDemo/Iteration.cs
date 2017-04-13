using System.Collections;

namespace IteratorPatternDemo
{
    public class Iteration : IEnumerable
    {
        internal int _startingPoing;
        internal object[] _values;

        public Iteration(object[] values, int startingPoint)
        {
            _values = values;
            _startingPoing = startingPoint;
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }
    }
}