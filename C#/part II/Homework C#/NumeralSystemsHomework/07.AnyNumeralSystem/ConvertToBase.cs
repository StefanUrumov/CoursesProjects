using _01.DecimalToBinary;
using _02.BinaryToDecimal;
using _03.DecimalToHex;
using _04.HexToDecimal;
using _05.HexToBinary;
using _06.BinaryToHex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AnyNumeralSystem
{
    class ConvertToBase
    {
        static void Main()
        {
            Console.WriteLine("Enter the numeral base of the your number (2, 10 or 16): ");
            int numBase = int.Parse(Console.ReadLine());

            Console.WriteLine("and numeral base in which you want your number to be converted (2, 10 or 16): ");
            int newBase = int.Parse(Console.ReadLine());

            while (numBase == newBase)
            {
                Console.WriteLine("Incorrect input! Equal numeral systems!");
                Console.WriteLine("Enter the numeral base of the first number (2, 10 or 16): ");
                numBase = int.Parse(Console.ReadLine());

                Console.WriteLine("and numeral base of the second number (2, 10 or 16): ");
                newBase = int.Parse(Console.ReadLine()); 
            }

            if (numBase == 10 && newBase == 2)
            {
                ConvertDecimal.Main();
            }

            if (numBase == 2 && newBase == 10)
            {
                BinToDec.Main();    
            }

            if (numBase == 10 && newBase == 16)
            {
                DecToHex.Main();
            }

            if (numBase == 16 && newBase == 10)
            {
                HexToDec.Main();
            }

            if (numBase == 16 && newBase == 2)
            {
                HexToBin.Main();
            }

            if (numBase == 2 && newBase == 16)
            {
                BinToHex.Main();
            }

        }
    }
}
