using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class MakeList<T>
    {
        public T[] collection = new T[10];
        int index = 0;

        public MakeList()
        {

        }   

        public void AddItem(T listitem)
        {
            collection[index] = listitem;
            index++;
        }

        public void ViewList()
        {
            Console.WriteLine("[{0}]", string.Join(", ", collection));
        }
    }
}

