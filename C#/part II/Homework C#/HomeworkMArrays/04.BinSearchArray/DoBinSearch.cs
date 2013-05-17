using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04.BinSearchArray
{
    class DoBinSearch
    {        
        static int[] array;
        static int size;
        static int targetNum; 

        static void Main()
        {
            Console.WriteLine("Enter size of the array: ");
            size = int.Parse(Console.ReadLine());

            CreateArray();
            
        }

        private static void CreateArray()
        {
            array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Enter target number: ");
            targetNum = int.Parse(Console.ReadLine());

            PrintArray();
            
        }

        private static void PrintArray()
        {
            Console.WriteLine("Your array of numbers is:");

            foreach (var nums in array)
            {
                Console.Write("{0} ", nums);
            }

            DoSorting();
        }

        private static void DoSorting()
        {
            int targetIndex = Array.BinarySearch(array, targetNum);

            while (targetIndex < 0)
            {
                if (targetNum < array[0])
                {
                    break;
                }
                targetNum--;
                targetIndex = Array.BinarySearch(array, targetNum);
            }

            Console.WriteLine();

            if (targetIndex < 0)
            {
                Console.WriteLine("Element not found!");
            }
            else
            {
                Console.WriteLine("Element <= target number found at index [{0}] = {1}", targetIndex, array[targetIndex]);
            }
        }

        



    }
}
