using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RectangleArea
{
    class RectangleArea
    {
        static void Main()
        {
            Console.WriteLine("To calculate the area of a rectangle, please enter:");
            Console.Write("- the width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("- the height: ");
            double height = double.Parse(Console.ReadLine()); ;

            double area = width * height;
            Console.WriteLine("The area of your rectangle  is: {0}!", area);
        }



    }
}
