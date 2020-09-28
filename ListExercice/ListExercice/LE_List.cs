using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ListExercice
{
    public class LE_List<T>
    {
        T[] myList = new T[0];
        public T this[int i] => myList[i];

        public int Count => myList.Length;

        public void Clear() => myList = new T[0];

        public void Add(T _toAdd)
        {
            T[] _temp = new T[Count + 1];

            for (int i = 0; i < Count; i++)
            {
                _temp[i] = myList[i];
            }
            _temp[Count] = _toAdd;
            myList = _temp;
        }

        public void RemoveAt(int _index)
        {
            if (_index > Count - 1)
            {
                Console.WriteLine($"Index {_index} is out of range, can't remove from outside the list");
                return;
            }

            T[] _temp = new T[Count - 1];
            for (int i = 0; i < _index; i++)
            {
                _temp[i] = myList[i];
            }
            for (int i = _index+1; i < Count; i++)
            {
                _temp[i-1] = myList[i];
            }
            myList = _temp;
        }
    }
}
