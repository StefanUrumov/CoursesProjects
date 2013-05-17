using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            Console.WriteLine("To calculate your trapezoid's area, please anter");
            Console.Write("- side 'a': ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("- side 'b': ");
            double sideB = double.Parse(Console.ReadLine());

            Console.Write("- height h: ");
            double heightH = double.Parse(Console.ReadLine());

            double areaS = ((sideA + sideB) * heightH) / 2;
            Console.WriteLine("The area is: {0}!", areaS);

        }
    }
}
