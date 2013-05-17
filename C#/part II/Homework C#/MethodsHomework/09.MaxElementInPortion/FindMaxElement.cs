using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MaxElementInPortion
{
    class FindMaxElement
    {
        static void Main()
        {
            int[] arr = new int[] { 2, 5, 9, 8, 5, 7, 3, 6, 3, 4, 2, 8, 6, 3, 2, 7, 8 };

            ShowNumbers(arr);

            FindMaxFromIndex(arr);

            ShowAscending(arr);
            
        }
        private static void ShowNumbers(int[] arr)
        {
            Console.WriteLine("In this array of numbers: ");

            foreach (var nums in arr)
            {
                Console.Write("{0} ", nums);    
            }
            Console.WriteLine();
        }

        private static void FindMaxFromIndex(int[] arr)
        {
            Console.WriteLine("to find bigeest number in a portion, enter number's position for a start: ");
            int position = int.Parse(Console.ReadLine());
            int max = 0;
            for (int i = position; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine(max);
        }

        private static void ShowAscending(int[] arr)
        {
            Console.WriteLine("Same array in ascending order: ");

            Array.Sort(arr);

            foreach (var nums in arr)
            {
                Console.Write("{0} ", nums);
            }
            Console.WriteLine();

            ShowDescending(arr);
        }

        private static void ShowDescending(int[] arr)
        {
            Console.WriteLine("In descending order: ");
            for (int index = arr.Length - 1; index >= 0; index--)
            {
                Console.Write("{0} ", arr[index]);
            }
            Console.WriteLine();
        }



    }
}
