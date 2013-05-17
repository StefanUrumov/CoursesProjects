using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SequenceOfGivenSum
{
    class FindGivenSum 
    {   
        static int[] array; 
        static int userSum;
        static int start;        
        static int end;
        
        static void Main()
        {
            Console.WriteLine("Enter target sum:");
            userSum = int.Parse(Console.ReadLine());

            array = new int[] { 4, 3, 1, 4, 2, 5, 8};

            CalculateSum();

        }

        private static void CalculateSum()
        {
            start = 0;
            end = 0;
            int sum = 0;
            bool foundSum = false;

            for (int index = 0; index < array.Length; index++)
            {
                sum = 0;
                for (int index2 = index; index2 < array.Length; index2++)
                {
                    sum += array[index2];

                    if (sum == userSum)
                    {
                        start = index;
                        end = index2;
                        foundSum = true;                        
                    }            
                }
            }

            if (foundSum == true)
            {
                PrintResult();
            }
            else
            {
                Console.WriteLine("No such sum in the array!");
            }
                
            
            
        }

        private static void PrintResult()
        {
            Console.WriteLine("The numbers of your sum are:");
            for (int index = start; index <= end; index++)
            {
                Console.Write("{0}, ", array[index]);
            }

            Console.WriteLine();

        }
    }
}
