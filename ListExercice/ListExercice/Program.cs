using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercice
{
    class Program
    {
        static void Main(string[] args)
        {
            LE_List<int> _myList = new LE_List<int>();

            _myList.Add(4);
            _myList.Add(3);
            _myList.Add(2);
            _myList.Add(1);
            _myList.RemoveAt(5);

            foreach  (int _index in _myList)
            {
                Console.WriteLine(_index);
            }
            Console.ReadLine();
        }
    }
}
