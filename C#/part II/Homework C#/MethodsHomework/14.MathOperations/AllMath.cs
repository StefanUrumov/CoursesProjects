using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MathOperations
{
    class AllMath
    {
        static void Main()
        {
            Console.WriteLine("Enter number of arguments you want to use: ");
            int arrSize = int.Parse(Console.ReadLine());

            CreateArray(arrSize);
        }

        private static void CreateArray(int arrSize)
        {
            int[] arr = new int[arrSize];

           for (int i = 0; i < arr.Length; i++)
			{
                Console.WriteLine("Enter value for {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
           }

           PrintArray(arr);
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine("You array:");
            foreach (var num in arr)
            {
                Console.Write("{0} ",num);
            }
            Console.WriteLine();

            SumElements(arr);
            Console.WriteLine();

            ElementsProduct(arr);
            Console.WriteLine();

            AverageElement(arr);
            Console.WriteLine();

            MaxElement(arr);
            Console.WriteLine();
 
            MinElement(arr);
            Console.WriteLine();
        }

        public static void SumElements(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Sum of all array elements: {0}", sum);
        }

        public static void ElementsProduct(int[] arr)
        {
            long product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            Console.WriteLine("Product of all array elements: {0}", product);
        }

        public static void AverageElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Average element: {0}", sum / 2); 
        }

        public static void MaxElement(int[] arr)
        {

            int maxValue = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
            Console.WriteLine("Element with maximum value: {0}", maxValue);
        }

        public static void MinElement(int[] arr)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
            }

            Console.WriteLine("Element with minimum value: {0}", minValue);
        }

    }
}
