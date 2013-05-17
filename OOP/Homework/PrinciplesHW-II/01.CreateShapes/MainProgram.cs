using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateShapes
{
    class MainProgram
    {
        static void Main()
        {
            Shape tr = new Triangle(2.4, 1);
            Console.Write("Triangle's surface: ");
            Console.WriteLine( tr.CalculateSurface() );

            Shape re = new Rectangle(3.1, 7.3);
            Console.Write("Rectangle's surface: ");
            Console.WriteLine(re.CalculateSurface());

            Shape ci = new Circle(2.0);
            Console.Write("Circle's surface: ");
            Console.WriteLine(ci.CalculateSurface());            
        }
    }
}
