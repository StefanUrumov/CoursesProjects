using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Test
{
    class SomeTest
    {
        static void Main()
        {
            string students = Console.ReadLine();
            byte N = byte.Parse(students[0].ToString());
            byte L = byte.Parse(students[2].ToString());
            byte R = byte.Parse(students[4].ToString());
            byte[] arr = new byte[N];
            string noPenStudents = "";
            string havePenStudents = "";

            string noPen = Console.ReadLine();
            for (int i = 0; i < L * 2; i++)
            {
                byte penMissing = byte.Parse(noPen[i].ToString());
                //Console.WriteLine(penMissing + "*");
                noPenStudents += penMissing;                
                i++;

            }
            char[] arrA = noPenStudents.ToCharArray();

            //can be optimazed using only one loop, we have first nums, so second nums
            //are the rest from the sequence
            string pen = Console.ReadLine();
            for (int i = 0; i < R*2; i++)
            {
                byte havePen = byte.Parse(pen[i].ToString());
                //Console.WriteLine(havePen + "*");
                havePenStudents += havePen;
                i++;
            }
            char[] arrB = havePenStudents.ToCharArray();
            
            char[] arrC = new char[N];

            //use merge sort logic here

            foreach (var item in arrA)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("....................");
            foreach (var item in arrB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
