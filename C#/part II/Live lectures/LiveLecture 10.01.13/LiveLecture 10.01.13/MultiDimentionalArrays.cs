using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLecture_10._01._13
{
    class MultiDimentionalArrays
    {
        static void SomeMethod(int[,] nums)
        {
            nums[0, 0] = 100;

        }

        static void Main()
        {
            var numbers = new int[2, 2];
            Console.WriteLine(numbers[0, 0]);
            SomeMethod(numbers);
            Console.WriteLine(numbers[0, 0]);






        }
    }
}
