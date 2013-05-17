using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.MirrorCodes
{
    class Mirror
    {
        static void Main()
        {
            Console.WriteLine("Enter two 3-digit numbers (123 123):");
            string line = Console.ReadLine();

            string one = line[0].ToString();
            string two = line[1].ToString();
            string three = line[2].ToString();
            string a =  three + two + one;

            string four = line[4].ToString();
            string five = line[5].ToString();
            string six = line[6].ToString();
            string b = six + five + four;

            int first = int.Parse(a);
            int second = int.Parse(b);

            Console.WriteLine(Math.Max(first, second));


        }
    }
}
