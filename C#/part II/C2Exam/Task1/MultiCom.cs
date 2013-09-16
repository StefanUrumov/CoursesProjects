using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Task1
{
    class MultiCom
    {

        static string ConvertGagStringToNumber(string digit)
        {
            string result = "NO";

            switch (digit)
            {
                case "CHU": result = "0"; break;
                case "TEL": result = "1"; break;
                case "OFT": result = "2"; break;
                case "IVA": result = "3"; break;
                case "EMY": result = "4"; break;
                case "VNB": result = "5"; break;
                case "POQ": result = "6"; break;
                case "ERI": result = "7"; break;
                case "CAD": result = "8"; break;
                case "K-A": result = "9"; break;
                case "IIA": result = "10"; break;
                case "YLO": result = "11"; break;
                case "PLA": result = "12"; break;


                default:
                    break;
            }

            return result;
        }

        static BigInteger PowerOfNine(int power)
        {
            BigInteger result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 13;
            }

            return result;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            string partialInput = string.Empty;
            string nineSystemNumber = "";

            for (int i = 0; i < input.Length; i++)
            {
                partialInput += input[i];

                string currentDigit =
                    ConvertGagStringToNumber(partialInput);

                if (currentDigit != "NO")
                {
                    nineSystemNumber += currentDigit + " ";
                    partialInput = "";
                }
            }
            nineSystemNumber.Trim();
            // Console.WriteLine(nineSystemNumber);
            string[] nums = nineSystemNumber.Split(' ');

            List<string> newNums = new List<string>();
            
            foreach (var item in nums)
            {
                if (item != " " && item != "")
                {
                    newNums.Add(item);
                }
            }

            BigInteger result = 0;

            for (int i = 0; i < newNums.Count; i++)
            {
                
                    BigInteger digit =
                        BigInteger.Parse(newNums[i]);

                    result += digit * PowerOfNine(newNums.Count - i - 1);                    
                
            }

            Console.WriteLine(result);
        }



    }
}

