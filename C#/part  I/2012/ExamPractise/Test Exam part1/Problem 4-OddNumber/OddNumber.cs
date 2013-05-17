using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_OddNumber
{
    class OddNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            long result = 0;
            for (int i = 1; i <= N; i++)
            {
                long number = long.Parse(Console.ReadLine());
                result ^= number;
            }
            Console.WriteLine(result);

            /*
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[] { 9, -1, 0, 1, 2, 3, 2, 1, 0, -1};
            Array.Sort(arr);

            foreach (var numbers in arr)
            {
                Console.Write(numbers + " ");                               
            }
            Console.WriteLine();

            int len = 1;             
            int bestStart = arr[0];

            for (int indexInner = 1; indexInner < arr.Length - 1; indexInner++)
            {
                if (arr[indexInner] == arr[indexInner - 1])
                {                    
                    len++;
                }
                else
                {                    
                    len = 1;
                }
                if (len == 1) // > will find max 
                {                   
                    bestStart = arr[indexInner];
                }
            }
            Console.WriteLine("The number with odd occurrence in this array is: {0} ", bestStart);  
            */
        }
    }
}
