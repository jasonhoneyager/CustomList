using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            MakeList<string> makelist = new MakeList<string>();
            while (loop == true)
            {
                Console.WriteLine("Enter List Variable");
                var listitem = Console.ReadLine();
                string listitem2 = Convert.ToString(listitem);
                makelist.AddItem(listitem2);
                makelist.ViewList();
                Console.ReadKey();
            }
        }
    }
}
