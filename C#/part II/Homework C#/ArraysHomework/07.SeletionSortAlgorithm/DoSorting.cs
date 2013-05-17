using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SeletionSortAlgorithm
{
    class DoSorting
    {
        static void Main()
        {   
            int [] array =  new int [] {10, 5, 2, 4, 1, 6, 8, 7, 9, 3};
  
            Console.WriteLine("The array before Selection Sort is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
 
            // selection sort algorithm
            int value = 0;
            int minValue = 0;

            for (int index = 0; index < array.Length - 1; index++)
            {
                minValue = index;

                for (int index2 = index + 1; index2 < array.Length; index2++)
                {
                    if (array[index2] < array[minValue])
                    {
                        minValue = index2;
                    }
                }

                value = array[minValue];
                array[minValue] = array[index];
                array[index] = value;
            }

            Console.WriteLine();
            Console.WriteLine("The array after Selection Sort is: ");
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

        }
    }
}
