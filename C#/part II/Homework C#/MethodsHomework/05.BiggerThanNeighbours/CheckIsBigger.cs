using _04.RepeatingCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BiggerThanNeighbours
{
    public class CheckIsBigger
    {
        static int[] numArray;
        static byte position;

        static void Main()
        {
            numArray = new int[] { 2, 4, 6, 8, 2, 4, 3, 2, 4, 6, 7, 9, 7, 5, 4, 2, 2 };

            CheckCounter.ShowArray(numArray);

            CheckPosition();

            Console.WriteLine("The number at position {0} is bigger than it's neighbours? -> {1}", position, CheckIndex());
        }

        public static void CheckPosition()
        {
            Console.WriteLine("Enter element's index(length - 1): ");
            position = byte.Parse(Console.ReadLine());

            CheckIndex();
        }

        public static bool CheckIndex()
        {
            bool bigger = false;

            if (position == 0)
            {
                if (numArray[position] > numArray[1])
                {
                    bigger = true;
                }
            }

            if (position == numArray.Length)
            {
                if (numArray[position] > numArray[numArray.Length - 1])
                {
                    bigger = true;
                }
            }

            if (position != 0 && position < numArray.Length)
            {
                if (numArray[position] > numArray[position - 1] && numArray[position] > numArray[position + 1])
                {
                    bigger = true;
                }
            }
            return bigger;
        }

    }
}
