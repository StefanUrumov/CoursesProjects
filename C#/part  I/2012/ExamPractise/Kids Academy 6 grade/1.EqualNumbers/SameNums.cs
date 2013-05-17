using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.EqualNumbers
{
    class SameNums
    {
        static void Main()
        {
            Console.WriteLine("Enter number of students (2..100): ");
            byte students = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter students heught using space (h1 h2 h3)");
            string heights = Console.ReadLine();

            string[] heightArr = heights.Split(' ');
            
            byte counter = 0;

            for (int index = 1; index < heightArr.Length; index++)
            {
                //Console.WriteLine(heightArr[index]);

                if (heightArr[index - 1] == heightArr[index])
                {
                    counter++;                    
                }
            heightArr[index - 1] = heightArr[index];
            }
            Console.WriteLine(counter * 2); //must be pairs of students so x2

        }
    }
}
