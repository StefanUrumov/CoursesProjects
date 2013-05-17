using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Gifts
{
    class Gifts
    {
        static void Main()
        {
            Console.WriteLine("Enter the line length (m cm)");
            string line = Console.ReadLine();

            Console.WriteLine("Enter number of gifts:");
            byte gifts = byte.Parse(Console.ReadLine());
                        
            string metersStr = line[0].ToString();
            string centimetersStr = line[2].ToString();
            string lineAll = metersStr + centimetersStr;
            decimal lineLength = decimal.Parse(lineAll);
            decimal lineFinal = lineLength / 10;

            decimal needed = lineFinal * gifts;
            Console.WriteLine(needed);
            


        }
    }
}
