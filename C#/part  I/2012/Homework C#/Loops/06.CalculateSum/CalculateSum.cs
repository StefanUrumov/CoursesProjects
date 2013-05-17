using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateSum
{
    class CalculateSum
    {
        static int N;
        static int X;
        static int index;        
        static decimal factorialOfN;
        static decimal resultPow;
        static decimal sum;
        
        
                
        
        static void Main()
        {
            Console.WriteLine("Enter value for N: ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for X: ");
            X = int.Parse(Console.ReadLine());

            while (N < 1)
            {
                Console.WriteLine("Incorrect input!");
                Console.Write("enter value for N:");
                N = int.Parse(Console.ReadLine());
            }

            DoSomeMath();
        }

        private static void DoSomeMath()
        {
            
                factorialOfN = 1;
                resultPow = 1;
                sum = 1;

                for ( index = 1; index <= N; index++)
                {
                   factorialOfN *= index;                     
                   resultPow *= X;
                   sum += (decimal)factorialOfN / (decimal)resultPow;                                                               
                    
        
                   //Console.WriteLine(index + "index");
                   //Console.WriteLine(factorialOfN + "fac");
                   //Console.WriteLine(resultPow + "pow");
                   //Console.WriteLine(sum + "maybe");                   
                   //Console.WriteLine();

                }

            Console.WriteLine("The sum of S = 1 + 1!/X + 2!/X^2 + … + N!/X^N is {0}", sum + 1);
            
        }

    }
}
