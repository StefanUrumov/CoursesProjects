using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _05.SortStringArray
{
    class CalculateLength
    {
        static string [] array;
        static int size;
        
        static void Main()
        {
            Console.WriteLine("Enter size of the array: ");
            size = int.Parse(Console.ReadLine());

            CreateArray();
            
        }

        private static void CreateArray()
        {
            array = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value for {0}: ", i);
                array[i] = Console.ReadLine();
            }

            PrintArray();
        }

        private static void PrintArray()
        {
            Console.WriteLine("Your array of strings: ");

            foreach (var str in array)
            {
                Console.Write("{0} ", str);
            }

            Console.WriteLine();

            SortStrings();
        }

        private static void SortStrings()
        {
            Console.WriteLine("Same string array sorted by each element's length:");
            foreach (string str in LenghtSort(array))
            {
                Console.Write("{0} ", str);
            }

            Console.WriteLine();
        }

        static IEnumerable<string> LenghtSort(IEnumerable<string> e)
        {
            var sortedStr = from str in e
                            orderby str.Length ascending
                            select str;
            return sortedStr;
        }
    }
}
