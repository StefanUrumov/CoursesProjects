using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CirclePoint
{
    class CirclePoint
    {
        static void Main()
        {
            Console.WriteLine("Enter your point (x, y) and see if it is in a circle K((0, 0), 5)");
            Console.Write("- x: ");
            double xPoint = double.Parse(Console.ReadLine());

            Console.Write("- y: ");
            double yPoint = double.Parse(Console.ReadLine());

            double circle = (xPoint * xPoint) + (yPoint * yPoint);

            if (circle <= 25)
            {
                Console.WriteLine("Your point is within a circle with r=5");
            }
            else
            {
                Console.WriteLine("Your point is outside of a circle with r=5");
            }
        }
    }
}
