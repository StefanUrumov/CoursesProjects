using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.CartesianCoordinateSystem
{
    class CoordinateSystem
    {
        static void Main()
        {
            long x = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine(0);
            }
            if (x == 0 && y != 0)
            {
                Console.WriteLine(5);
            }
            if (y == 0 && x != 0)
            {
                Console.WriteLine(6);
            }
            if (x > 0 && y > 0)
            {
                Console.WriteLine(1);
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine(2);
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine(3);
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine(4);
            }

        }
    }
}
