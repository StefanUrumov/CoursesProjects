using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Circle
{
    class Circle
    {
        static double r;

        static void Main()
        {
            Console.WriteLine("Enter radius of your circle:");
            string line = Console.ReadLine();
            r = 0;

            if (double.TryParse(line, out r))
            {
                Console.WriteLine("Please press: ");
                Console.WriteLine("- '1' to calculate area!");
                Console.WriteLine("- '2' to calculate perimeter!");

                ConsoleKeyInfo info = Console.ReadKey();

                if (info.Key == ConsoleKey.D1)
                {
                    CalculateArea();
                }
                if (info.Key == ConsoleKey.D2)
                {
                    CalculatePerimeter();
                }
            }
            else
            {
                Console.WriteLine("Invalid number {0}", line);
            }
        }


        static void CalculateArea()
        {
            double area = Math.PI * (r * r);
            Console.WriteLine("The area of the circle is {0}", area);
        }


        static void CalculatePerimeter()
        {
            double perimeter = 2 * (Math.PI * r);
            Console.WriteLine("The perimeter of the circle is {0}", perimeter);
        }
    }
}
