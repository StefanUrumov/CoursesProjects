using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxElementsSum
{
    class FindMaxSum
    {
        static int[] array;
        static int size;
        static int maxSumElements;

        static void Main()
        {
            Console.WriteLine("Enter size of the array: ");
            size = int.Parse(Console.ReadLine());

            CreateArray();
            
            Console.WriteLine("Enter a number of elements to form the max sum: ");
            maxSumElements = int.Parse(Console.ReadLine());

            FindBestSum();
        }

        private static void CreateArray()
        {
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
            }                        
        }

        private static void FindBestSum()
        {
            Array.Sort(array);

            Console.WriteLine("The elements with max sum are: ");

            for (int i = array.Length - maxSumElements; i < array.Length; i++)
            {
                Console.Write("{0}, ", array[i]);    
            }
        }
    }
}
