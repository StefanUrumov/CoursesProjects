using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinaryToHex
{
    public class BinToHex
    {
        public static void Main()
        {
            Console.WriteLine("Enter binary number: ");
            string inBin = Console.ReadLine();

            string inHex = string.Empty;

            inHex = Convert.ToString(Convert.ToUInt32(inBin, 2), 16);
            
            Console.WriteLine(inHex);
        }
    }
}
