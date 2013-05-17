using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.FactorialsEquation
{
    class FactorialsEquation
    {
        static BigInteger N;
        static BigInteger K;
        static BigInteger factorialOfN;
        static BigInteger factorialOfK;



        static void Main()
        {
            Console.WriteLine("If 1<N<K,");
            Console.Write("enter value for N:");
            N = BigInteger.Parse(Console.ReadLine());
            Console.Write("enter value for K:");
            K = BigInteger.Parse(Console.ReadLine());

            while (N < 1 || N > K)
            {
                Console.WriteLine("Incorrect input!");
                Console.Write("enter value for N:");
                N = BigInteger.Parse(Console.ReadLine());
            }

            CalculateFactorials();
        }

        static void CalculateFactorials()
        {
            try
            {
                factorialOfN = 1;
                for (BigInteger index = 1; index <= N; index++)
                {
                    factorialOfN *= index;

                }
                //Console.WriteLine(factorialOfN);

                factorialOfK = 1;
                for (BigInteger index = 1; index <= K; index++)
                {
                    factorialOfK *= index;

                }
                //Console.WriteLine(factorialOfK);                
            }
            catch (Exception e)
            {
                Console.WriteLine("An error has been found: {0}", e.Message);
                Console.WriteLine("Source = {0}", e.Source);
                Console.WriteLine("StackTrace = {0}", e.StackTrace);
                Console.WriteLine("TargetSite = {0}", e.TargetSite);
            }

            PrintResult();
        }

        static void PrintResult()
        {
            BigInteger result = (factorialOfN * factorialOfK) / (factorialOfK - factorialOfN);
            Console.WriteLine("The final result of the 'N!*K! / (K-N)!'  equation is: {0}", result);
        }


    }
}
