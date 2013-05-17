using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Windows
{
    class SomeWindows
    {
        static void Main()
        {
            Console.WriteLine("Enter number of windows and price (3 2)");
            string line = Console.ReadLine();

            string windows = line[0].ToString();
            string price = line[2].ToString();

            byte windowsNum = byte.Parse(windows);
            short priceCoast = short.Parse(price);

            int sum = 0;

            for (int i = 0; i < windowsNum; i++)
            {
                Console.WriteLine("Enter window heugth width broken (20 40 1)");
                string input = Console.ReadLine();

                string h = input[0].ToString() + input[1].ToString(); 
                byte heigth = byte.Parse(h);

                string w = input[3].ToString() + input[4].ToString();
                byte width = byte.Parse(w);

                int area = heigth * width;

                if (input[6].ToString() == "1")
                {
                    sum += area;
                }
                if (input[6].ToString() == "0")
                {
                    sum += 0;
                }
                
            }
            Console.WriteLine(sum * priceCoast);




        }
    }
}
