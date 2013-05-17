using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Least_Majority_Multiple
{
    class CMM
    {
        static void Main()
        {
            //Console.WriteLine("Enter five numbers [1-100]:");
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            byte c = byte.Parse(Console.ReadLine());
            byte d = byte.Parse(Console.ReadLine());
            byte e = byte.Parse(Console.ReadLine());

            // НОК = НОД*(A1/НОД)*(А2/НОД) *...* (An/НОД)

            for (int i = 1; true; i++)
            {
                int count = 0;
                if (i % a == 0) count++;
                if (i % b == 0) count++;
                if (i % c == 0) count++;
                if (i % d == 0) count++;
                if (i % e == 0) count++;
                if (count >= 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
