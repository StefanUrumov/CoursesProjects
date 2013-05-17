using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.GivenPoint
{
    class GivenPoint
    {
        static double pointX;
        static double pointY;


        static void Main()
        {
            Console.WriteLine("Define your point by entering the ");
            Console.Write("- x: ");
            pointX = double.Parse(Console.ReadLine());

            Console.Write("- y: ");
            pointY = double.Parse(Console.ReadLine());

            CheckCircle();
        }

        static void CheckCircle()
        {
            double circle = (pointX * pointX) + (pointY * pointY);

            if (circle <= 9)
            {
                Console.Write("Your point is within the circle K((1, 1), 3), and ");

                CheckRectangle();
            }
            else
            {
                Console.WriteLine("Your point is outside of the circle K((1, 1), 3)!");
            }

        }


        static void CheckRectangle()
        {
            if ((pointX < -1 && pointX > 5) && (pointY < -1 && pointY > 1))
            {
                Console.Write(" is outside of the rectangle R(top=1, left=-1, width=6, height=2)!");
            }
            else
            {
                Console.Write(" is within the rectangle R(top=1, left=-1, width=6, height=2)!");
            }

            Console.WriteLine();
        }

           
    }
}
