using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class UseBinSearch
    {
        static void Main()
        {
            int[] array = new int[] { 3, 0, 10, 1, 6, 8, 2, 4, 7, 5, 9};

            Array.Sort(array);
            foreach (var item in array)
            {
                Console.Write(" " + item);
            }

            Console.WriteLine();
            Console.WriteLine("Enter a number from this array:");
            int userNumber = int.Parse(Console.ReadLine());

            int index = Array.BinarySearch(array, userNumber);
            Console.WriteLine("You number index array position is: " + index);    

        }
    }
}
