using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveArrays_09._01._13
{
    class LiveLecture
    {
        static void Main()
        {
            //may also learn regular expressions + strings

            int[] array = { 1,2,3,4,5 };
            int [] reversed = new int[array.Length];

            for (int i = 0; i < reversed.Length; i++) //no need for reversed.Length - 1
            {
                reversed[i] = array[array.Length - 1 - i]; //here we move thrue all array elements
            }

            foreach (var item in reversed) //this loop can't print array index!!!
            {
                Console.WriteLine(item);
            }
        }
    }
}
