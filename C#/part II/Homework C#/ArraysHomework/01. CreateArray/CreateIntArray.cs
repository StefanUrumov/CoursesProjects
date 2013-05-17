using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CreateArray
{
    class CreateIntArray
    {
        static void Main()
        {
            int[] myArray = new int[] { 12, 23, 543, 2342, 23, 21, 59, 85, 36, 93, 3, 22, 13, 54, 84, 6363, 643, 229, 30, 100};

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 5;
                Console.WriteLine(myArray[i]);
            }






        }
    }
}
