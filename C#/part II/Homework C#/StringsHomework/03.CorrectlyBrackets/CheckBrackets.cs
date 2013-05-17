﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectlyBrackets
{
    class CheckBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter text (use brackets)!");
            string text = Console.ReadLine();
            int count = 0;

            string key1 = "(";
            string key2 = ")";

            int index1 = text.IndexOf(key1);
            int index2 = text.IndexOf(key2);


            while (index1 != -1)
            {
                Console.WriteLine("{0} found at index: {1}", key1, index1);
                index1 = text.IndexOf(key1, index1 + 1);
                if (key1 == "(")
                {
                    count += 1;
                }

            }

            while (index2 != -1)
            {
                Console.WriteLine("{0} found at index: {1}", key2, index2);
                index2 = text.IndexOf(key2, index2 + 1);
                if (key1 == "(")
                {
                    count -= 1;
                }
            }

            if (count == 0)
            {
                //Console.WriteLine(count);
                Console.WriteLine("Your arithmetic expression is correct(equal amount of used brackets!)");
            }
            else
            {
                Console.WriteLine("Your arithmetic expression is incorrect(not equal amount of used brackets!)");
            }
        }
    }
}
