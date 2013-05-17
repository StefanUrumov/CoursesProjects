using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Grades
{
    class SomeGrades
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of judge scores (3 <= n <= 100): ");
            byte n = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter judge scores using space (n n1 n2....)");
            string line = Console.ReadLine();

            string[] separate = line.Split(' ');
            double judgeMark = 0;
            double commonScore = 0;
            

            for (int index = 1; index < n - 1; index++)
            {
                //Console.WriteLine(index);
                judgeMark = double.Parse(separate[index]);
                //Console.WriteLine(judgeMark);
                commonScore += judgeMark;
            }

            double finalScore = commonScore / (n - 2);
            //Console.WriteLine(commonScore);
            //Console.WriteLine(finalScore);

            string finalNum = finalScore.ToString();
            //Console.WriteLine(finalNum);

            byte tenth = byte.Parse(finalNum[2].ToString());
            //Console.WriteLine(tenth);

            if (tenth >= 5)
            {
                finalScore += 1;
                Console.WriteLine((int)finalScore);                
            }
            else
            {
                Console.WriteLine((int)finalScore);
            }





        }
    }
}
