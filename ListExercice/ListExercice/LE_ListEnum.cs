using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercice
{
    public class LE_ListEnum<T> : IEnumerator
    {
        public T[] mylistenum = new T[0];
        int position = -1;
        public T Current
        {
            get
            {
                return mylistenum[position];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public LE_ListEnum(T[] _list)
        {
            mylistenum = _list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < mylistenum.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
