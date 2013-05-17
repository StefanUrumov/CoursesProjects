using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSortAlgorithm
{
    class UseQuickSort
    {
        static void Main()
        {
            // we can just use Array.Sort which internally use Quicksort algorithm

            // First we create an unsorted array of strings
            string[] strArray = new string[] { "car", "cat", "dog", "boat", "bird", "song", "walk", "fox", "jump", "array", "sort", "mouse", "sky"};
            
            // Print the unsorted array
            Console.WriteLine("Array of unsorted strings: ");
            
            foreach (var stringElements in strArray)
            {
                Console.Write("{0}, ", stringElements);
            }

            Console.WriteLine();

            // Sort the array
            Quicksort(strArray, 0, strArray.Length - 1);

            Console.WriteLine("Same array after using QuickSort Algorithm: ");
            // Print the sorted array
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.Write(strArray[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int L = left, R = right;
            IComparable pivot = elements[(left + right) / 2];

            while (L <= R)
            {
                while (elements[L].CompareTo(pivot) < 0)
                {
                    L++;
                }

                while (elements[R].CompareTo(pivot) > 0)
                {
                    R--;
                }

                if (L <= R)
                {
                    // Swap
                    IComparable tmp = elements[L];
                    elements[L] = elements[R];
                    elements[R] = tmp;

                    L++;
                    R--;
                }
            }

            // Recursive calls
            if (left < R)
            {
                Quicksort(elements, left, R);
            }

            if (L < right)
            {
                Quicksort(elements, L, right);
            }
        }

    }
}
