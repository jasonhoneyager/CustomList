using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class MakeList<T>
    {
        int index = 0;
        public T[] collection = new T[1];

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

        public void SwapListValues()
        {
            T[]tempvalue = new T[index];
            tempvalue = collection;
            collection = new T[index + 1];
            int count = 0;
            foreach (T item in tempvalue)
            {
                collection[count] = item;
                count++;
            }
    }
    }
}

