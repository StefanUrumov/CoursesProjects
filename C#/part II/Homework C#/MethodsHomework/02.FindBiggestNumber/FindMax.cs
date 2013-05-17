using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FindBiggestNumber
{
    class FindMax
    {
        static int max;
        static void Main()
        {
            Console.WriteLine("Enter first number: ");
            int fiNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secNum = int.Parse(Console.ReadLine());
            
            GetMax(fiNum, secNum);
            
            Console.WriteLine("Enter third number: ");
            int thirdNum = int.Parse(Console.ReadLine());

            GetMax(max, thirdNum);

            Console.WriteLine("Biggest number: {0}", max);            
        }

        private static int GetMax(int fiNum, int secNum)
        {
            max = fiNum;
            if (fiNum < secNum)
            {
                max = secNum;
            }
            
            return max;
        }
    }
}
