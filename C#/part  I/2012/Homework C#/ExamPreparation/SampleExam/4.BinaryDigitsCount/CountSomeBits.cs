using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4.BinaryDigitsCount
{
    class CountSomeBits
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char digit = input[0];
            short N = short.Parse(Console.ReadLine());
            string number = " ";
            string inBinary = " ";
            string finalNumbers = " ";
            int counter = 0;
            
            for (int i = 0; i < N; i++)
            {
                number = Console.ReadLine();
                inBinary = Convert.ToString(Convert.ToInt64(number, 10), 2);                

                foreach (var element in inBinary)
	            {		            
                    if (element == digit)
                    {
                        counter++;
                    }                    
	            }
                finalNumbers += counter.ToString();
                finalNumbers += " ";
                counter = 0;
            }
                      

            string[] output = Regex.Split(finalNumbers, @"\D+");
            foreach  (string value in output)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    uint i = uint.Parse(value);
                    Console.WriteLine(i);
                }
            }
        }
    }
}
