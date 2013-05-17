using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Figures
{
    class Draw
    {
        static void Main()
        {
            Console.WriteLine("Enter the sides of the triangle: ");
            Console.WriteLine("-a :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("-b :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("-c :");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sides of the rectangle: ");
            Console.WriteLine("-a :");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("-b :");
            int h = int.Parse(Console.ReadLine());

            int result = ((a + b) - c) + (d + (2*h));

            Console.WriteLine("Total lenght: {0}", result);
        }
    }
}
