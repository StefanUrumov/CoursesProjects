using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.DivideFactorials
{
    class DivideFactorials
    {
        static BigInteger N;
        static BigInteger K;

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

            DoTheMath();           

        }

        static void DoTheMath()
        {
            try
            {
                BigInteger factorialOfN = 1;
                for (BigInteger index = 1; index <= N; index++)
                {
                    factorialOfN *= index;

                }
                Console.WriteLine(factorialOfN);

                BigInteger factorialOfK = 1;
                for (BigInteger index = 1; index <= K; index++)
                {
                    factorialOfK *= index;

                }
                Console.WriteLine(factorialOfK);

                BigInteger result = factorialOfN / factorialOfK;
                Console.WriteLine("N! / K! is: {0}", result);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("An error has been found: {0}", e.Message);
                Console.WriteLine("Source = {0}", e.Source);
                Console.WriteLine("StackTrace = {0}", e.StackTrace);
                Console.WriteLine("TargetSite = {0}", e.TargetSite);
            }
        }
    }
}
