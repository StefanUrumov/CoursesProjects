using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.RepeatingCounter;
using _05.BiggerThanNeighbours;


namespace _06.BiggerThanNeighbousIndex
{
    public class FindBigger
    {
        //i'm not using method from my previous task, because in task 05 this same method is bool 
        static int[] numArray;
        static sbyte index;

        static void Main()
        {
            numArray = new int[] { 2, 4, 6, 8, 2, 4, 3, 2, 4, 6, 7, 9, 7, 5, 4, 2, 2 };

            CheckCounter.ShowArray(numArray);
            FindFirstBiggerThanNeighbours();
            
            Console.WriteLine("The first number  bigger than it's neighbours is with index: {0}.", index);    
        }

        public static sbyte FindFirstBiggerThanNeighbours()
        {
            for (index = 0; index < numArray[index]; index++)
            {
                if (index != 0 && index < numArray.Length)
                {
                   if (numArray[index] > numArray[index - 1] && numArray[index] > numArray[index + 1])
                   {
                       return index;
                   } 
                }
            }           
            
            return -1;
        }

    }
}
