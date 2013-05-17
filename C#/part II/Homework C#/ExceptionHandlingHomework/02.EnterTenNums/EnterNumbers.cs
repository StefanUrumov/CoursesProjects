using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterTenNums
{
    class EnterNumbers
    {
        static int[] arr;

        static void Main()
        {
            Console.WriteLine("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number: ");
            int end = int.Parse(Console.ReadLine());

            ReadNumber(start, end);
            
            CheckSequence();

        }

        private static void CheckSequence()
        {
            for (int index = 1; index <= arr.Length; index++)
            {
                if (arr[index] < arr[index - 1])
                {
                    throw new Exception("Not increasing sequence!");
                }
            }
            
        }

        private static int [] ReadNumber(int start,int end)
        {
            Console.WriteLine("Now enter 10 numbers in range [{0}...{1}]", start, end);
            arr = new int[10];
            int num = 0;
            try
            {
                for (int inner = 0; inner < arr.Length; inner++)
                {
                    Console.WriteLine("enter {0}:", inner);
                    num = int.Parse(Console.ReadLine());
                    if (num < start || num > end)
                    {
                        throw new ArgumentOutOfRangeException("Invalid numer! Your entry is out of range!");
                    }                    
                    arr[inner] = num;
                }                
            }
            catch (ArgumentException)
            {                
                throw new Exception("Invalid number!");
            }

            Console.WriteLine("Your array: ");
            for (int index = 0; index < arr.Length; index++)
            {
                Console.Write(" {0} ", arr[index]);
            }
            Console.WriteLine();
            return arr;
        }
    }
}
