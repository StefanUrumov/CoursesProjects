using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HexToBinary
{
    public class HexToBin
    {
        public static void Main()
        {
            Console.WriteLine("Enter hex number: ");
            string inHex = Console.ReadLine();

            string inBinary = string.Empty;

            foreach (var element in inHex)
            {
                inBinary += Convert.ToString(Convert.ToUInt32(element.ToString(), 16), 2);
            }

            Console.WriteLine(inBinary);
        }
    }
}
