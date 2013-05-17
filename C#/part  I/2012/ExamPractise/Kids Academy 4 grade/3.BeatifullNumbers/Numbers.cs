using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BeatifullNumbers
{
    class Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 digit number: ");
            string line = Console.ReadLine();

            byte first = byte.Parse(line[0].ToString());
            byte second = byte.Parse(line[1].ToString());
            byte third = byte.Parse(line[2].ToString());
            byte fourth = byte.Parse(line[3].ToString());
            byte fifth = byte.Parse(line[4].ToString());
            int sum = second + third + fourth + fifth;

            if (first >= sum)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
