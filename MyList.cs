using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_module3
{
   public class MyList<T> : IEnumerable
    {
        private T[] _items = new T[0];

        public void Add(T item)
        {
            if (_items.Length - 1 != default)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }

            _items[_items.Length - 1] = item;
        }

        public void AddRange(T[] items)
        {
            Array.Resize(ref _items, _items.Length + items.Length);
            Array.Copy(items, 0, _items, _items.Length - items.Length, items.Length);
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(_items, item);
            if (index < 0)
            {
                return false;
            }

            for (int i = index; i < _items.Length - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            Array.Resize(ref _items, _items.Length - 1);

            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _items.Length - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            Array.Resize(ref _items, _items.Length - 1);
        }

        public void Sort()
        {
            Array.Sort(_items);
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnum<T>(_items);
        }
    }
}
