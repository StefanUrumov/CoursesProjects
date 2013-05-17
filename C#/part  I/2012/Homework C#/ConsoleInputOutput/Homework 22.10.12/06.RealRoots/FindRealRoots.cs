using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RealRoots
{
    class FindRealRoots
    {
       static int a;
       static int b;
       static int c;

        static void Main()
        {
            Console.WriteLine("Enter coefficients of a quadratic equation ax2+bx+c=0: ");
            Console.Write("- a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("- b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("- c: ");
            c = int.Parse(Console.ReadLine());


            if (a != 0)
            {
                FindDiscriminant();
            }
            else{
                Console.WriteLine("The equation is not quadratic!");
            }            
        }

        static void FindDiscriminant()
        {
            double discriminant = b * b - (4 * a * c);

            if (discriminant < 0)
            {
                Console.WriteLine("Your quadratic equation has no real roots!");
            }
            if (discriminant == 0)
            {
                int x = -b / (2 * a);                
                Console.WriteLine("Your quadratic equation has one (double) real root: {0}", x);
            }
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
 

                Console.WriteLine("Your quadratic equation has two real roots: x1={0} and x2={1}", x1, x2);
            }
        }

    }
}
