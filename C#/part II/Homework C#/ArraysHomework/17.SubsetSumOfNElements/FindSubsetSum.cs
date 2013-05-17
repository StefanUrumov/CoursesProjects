using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SubsetSumOfNElements
{
    class FindSubsetSum
    {
        static void Main()
        {
            Console.WriteLine("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());

            int [] array = new int[size];

            for (int index = 0; index < size; index++)
            {
                Console.WriteLine("Enter element {0} value:", index);
                array[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter target sum: ");
            int targetSum = int.Parse(Console.ReadLine());
 
            Console.WriteLine("Enter how many elements can form the sum:");
            int elementsUsed = int.Parse(Console.ReadLine());


            int result = SubsetSumCheck(array, targetSum, elementsUsed);
            if (result > 0)
            {
                resultPrinter(array, result);
            }
            else
            {
                Console.WriteLine("Solution not found. ");
            }
        }

        static void resultPrinter(int[] array, int result)
        {
            Console.WriteLine("Best found: ");
            for (int i = 0; i < array.Length; i++)
            {
                if ((result & (1 << i)) != 0)
                {
                    Console.Write("({0}) ", array[i]);
                }
            }
            Console.WriteLine();
        }

        static int SubsetSumCheck(int[] array, int targetSum, int targetElementsUsed)
        {
            for (int combinationNumber = 1; combinationNumber < (1 << array.Length); combinationNumber++)
            {
                int sum = 0;
                int elementsUsed = 0;
                for (int indexOfElement = 0; indexOfElement < array.Length; indexOfElement++)
                {
                    if ((combinationNumber & (1 << indexOfElement)) != 0)
                    {
                        sum += array[indexOfElement];
                        elementsUsed++;
                        if (elementsUsed == targetElementsUsed)
                        {
                            break;
                        }
                    }
                }
                if (sum == targetSum && elementsUsed == targetElementsUsed)
                {
                    return combinationNumber;
                }
            }
            return 0;
        }

    }
}
