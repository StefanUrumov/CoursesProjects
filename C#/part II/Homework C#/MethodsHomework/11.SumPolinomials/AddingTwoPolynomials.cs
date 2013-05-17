using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.SumTwoArrays;

namespace _11.SumPolinomials
{
    class AddingTwoPolynomials
    {
        //not working properly if 0 is used
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter variable for your equation!");
            string var = Console.ReadLine();

            Console.WriteLine("Enter the number of the highest math pow of '{0}' for the first polynomial!", var);
            int varPow = int.Parse(Console.ReadLine());

            int[] array = new int[varPow + 1];

            CreateFirstPolynomial(array, var, varPow);
            Console.WriteLine();

            Console.WriteLine("Enter the number of the highest math pow of '{0}' for the second polynomial!", var);
            int varPow2 = int.Parse(Console.ReadLine());

            int[] array2 = new int[varPow2 + 1];

            CreateSecondPolynomial(array2, var, varPow2);

            DoMath.FindFinalSum(array, array2);           

        }

        static string CreateFirstPolynomial(int[] array, string var, int varPow)
        {
            for (int powSeq = 0; powSeq < array.Length; powSeq++)
            {
                Console.Write("Enter coefficient for {0}^{1}: ", var, powSeq);
                array[powSeq] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your first polynomial is:");
            PrintFirstPolynomial(array, varPow, var);

            return var;
        }

        static string PrintFirstPolynomial(int[] array, int varPow, string var)
        {
            for (int index = 0; index <= varPow; index++)
            {
                Console.Write("{0}{1}^{2} + ", array[index], var, index);
            };
            Console.WriteLine();

            return var;
        }

        static string CreateSecondPolynomial(int[] array2, string var, int varPow2)
        {
            for (int powSeq = 0; powSeq < array2.Length; powSeq++)
            {
                Console.Write("Enter coefficient for {0}^{1}: ", var, powSeq);
                array2[powSeq] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your second polynomial is:");
            PrintSecondPolynomial(array2, varPow2, var);

            return var;
        }

        static string PrintSecondPolynomial(int[] array2, int varPow2, string var)
        {
            for (int index = 0; index <= varPow2; index++)
            {
                Console.Write("{0}{1}^{2} + ", array2[index], var, index);
            };
            Console.WriteLine();

            return var;
        }

        

    }
}
