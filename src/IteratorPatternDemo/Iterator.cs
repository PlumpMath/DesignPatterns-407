using System;
using System.Collections;

namespace IteratorPatternDemo
{
    public class Iterator : IEnumerator
    {
        private readonly Iteration _parent;
        private int _postion;

        internal Iterator(Iteration iteration)
        {
            _parent = iteration;
            _postion = -1;
        }

        public bool MoveNext()
        {
            if (_postion != _parent._values.Length)
                _postion++;
            return _postion < _parent._values.Length;
        }

        public void Reset()
        {
            _postion = -1;
        }

        public object Current
        {
            get
            {
                if (_postion == -1 || _postion == _parent._values.Length)
                    throw new InvalidOperationException();
                var index = _postion + _parent._startingPoing;
                index = index % _parent._values.Length;
                return _parent._values[index];
            }
        }
    }
}