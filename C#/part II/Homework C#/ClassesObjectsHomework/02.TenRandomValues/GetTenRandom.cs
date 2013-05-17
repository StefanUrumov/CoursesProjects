using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TenRandomValues
{
    class GetTenRandom
    {
        static int randomNum;

        static void Main(string[] args)
        {
            Console.WriteLine("If your numbers are between 100 and 200!");
            Console.WriteLine("Your random 10 numbers are: ");

            GetRandomNumbers();
        }


        static void GetRandomNumbers()
        {
            Random rand = new Random();

            for (int number = 1; number <= 10; number++)
            {
                randomNum = rand.Next(100, 200) + 1;
                Console.Write(" {0} ", randomNum);
            }
            Console.WriteLine();
        }
    }
}
