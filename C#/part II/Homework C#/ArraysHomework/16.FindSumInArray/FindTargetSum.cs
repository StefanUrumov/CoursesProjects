using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.FindSumInArray
{
    class FindTargetSum
    {
        //not the best method, but generally works        
        static void Main()
        {
            int[] array = new int[] { 2, 1, 2, 4, 3, 5, 2, 6};
            
            Console.WriteLine("Enter target sum: ");
            int targetSum = int.Parse(Console.ReadLine());

            int index = 0;
            int current = 0;
            string result = " ";            
            FindNumbers( array, index, current, targetSum, result);
        }


        static void FindNumbers(int[] array, int index, int current, int targetSum, string result)
        {
            if (array.Length < index || current > targetSum)
            {
                return;
            }
                for (int i = index; i < array.Length; i++)
            {
                if (current + array[i] == targetSum)
                {
                    Console.WriteLine("yes:");
                    Console.WriteLine(result + " " + array[i].ToString());
                }
                else if (current + array[i] < targetSum)
                {
                    FindNumbers(array, i + 1, current + array[i], targetSum, result + " " + array[i].ToString());
                }                
            }
        }




    }
}
