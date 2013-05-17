using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompareArrays
{
    class CompareTwoArrays
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the first array:");
            int sizeFirst = int.Parse(Console.ReadLine());

            int [] firstArray = new int[sizeFirst];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("Enter element {0}: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the size of the second array:");
            int sizeSecond = int.Parse(Console.ReadLine());

            int[] secondArray = new int[sizeSecond];

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.WriteLine("Enter element {0}: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            int lengthFi = firstArray.Length;
            int lengthSe = secondArray.Length;

            for (int index = 0; index < firstArray.Length; index++)
            {
                for (int index2 = 0; index2 < secondArray.Length; index2++)
                {
                    if (index != index2 && lengthFi != lengthSe)
                    {
                        Console.WriteLine("Those two arrays elements are NOT equal!");
                    }
                    else
                    {
                        Console.WriteLine("Those two arrays elements are equal!");
                    }
                }                
            };
            Console.WriteLine();
        }
    }
}
