using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_module3
{
    public class MyListEnum<T> : IEnumerator
    {
        private T[] _items;
        private int _position = -1;

        public MyListEnum(T[] items)
        {
            _items = items;
        }

        public T Current
        {
            get
            {
                if (_position == -1 || _position >= _items.Length)
                {
                    throw new InvalidOperationException();
                }

                return _items[_position];
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (_position < _items.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }

        public void Dispose()
        {
        }
    }
}
