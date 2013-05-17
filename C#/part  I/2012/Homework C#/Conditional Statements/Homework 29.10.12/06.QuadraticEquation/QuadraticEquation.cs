using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("If your quadratic equation is a*x^2 + b*x + c = 0, enter");
            Console.WriteLine("- a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("- b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("- c:");
            int c = int.Parse(Console.ReadLine());

            double Discriminant = b*b - (4*a*c);

            if (a == 0)
            {
                Console.WriteLine("Your equation is not quadratic!");
            }
            else
            {
                if (Discriminant == 0)
                {
                    int x = -b / 2 * a;
                    Console.WriteLine("The equation has one double real root x1,2 = {0}", x);
                }
                if (Discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(Discriminant)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(Discriminant)) / 2 * a;
                    Console.WriteLine("The equation has two real roots x1 = {0} and x2 = {1}", x1, x2);
                }
                if (Discriminant < 0)
                {
                    Console.WriteLine("The equation has no real roots!");
                }
            }
            Console.WriteLine(Discriminant);
        }
    }
}
