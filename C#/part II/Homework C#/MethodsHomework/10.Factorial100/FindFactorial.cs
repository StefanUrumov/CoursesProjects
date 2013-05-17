using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace _10.Factorial100
{
    class FindFactorial
    {
        static void CalculateFactorial(BigInteger factNum, int num)
        {
            Console.Write("The factorial of {0} ", num);

            do
            {
                factNum *= num;
                num--;
            } while (num > 0);
            
            Console.Write("is: {0}", factNum);
        }

        static void Main(string[] args)
        {
            BigInteger factNum = 1;
            int num = 0;

            for (int i = 1; i <= 100; i++)
            {
                num = i;
                CalculateFactorial(factNum, num);
                Console.WriteLine();
            }
        }

    }
}
