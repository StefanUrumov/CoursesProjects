using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.InOrder
{
    class Ordered
    {
        static void Main()
        {
            Console.WriteLine("Enter flower pots height (h1 h2 h3 h4):");
            string line = Console.ReadLine();

            var elements = line.Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            byte h1 = byte.Parse(elements[0].ToString());
            byte h2 = byte.Parse(elements[1].ToString());
            byte h3 = byte.Parse(elements[2].ToString());
            byte h4 = byte.Parse(elements[3].ToString());

            if (h1 < h2 && h2 < h3 && h3 < h4)
            {
                Console.WriteLine("Ascending");
            }
            if (h1 > h2 && h2 > h3 && h3 > h4)
            {
               Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Mixed");
            }



        }
    }
}
