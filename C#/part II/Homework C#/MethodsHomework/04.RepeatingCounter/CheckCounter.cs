using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RepeatingCounter
{
    public class CheckCounter
    {  
        static void Main()
        {
            int[]  numArray = new int[] { 2, 4, 6, 8, 2, 4, 3, 2, 4, 6, 7, 9, 7, 5, 4, 2, 2};

            ShowArray(numArray);

            PrintRepeatingElements(numArray);
             
        }

        public static void ShowArray(int[] numArray)
        {
            Console.WriteLine("In this array of numbers: ");

            foreach (var num in numArray)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
           
        }

        public static int CountElements(int[] numArray, int element)
        {
            int counter = 0;

            for (int index = 0; index < numArray.Length; index++)
            {
                if (numArray[index] == element)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void PrintRepeatingElements(int[] numArray)
        {
            for (int index = 0; index < numArray.Length; index++)
            {
                Console.WriteLine("Element {0} is repeating {1} times.", numArray[index], CountElements(numArray, numArray[index]));
            }
        }

    }
}
