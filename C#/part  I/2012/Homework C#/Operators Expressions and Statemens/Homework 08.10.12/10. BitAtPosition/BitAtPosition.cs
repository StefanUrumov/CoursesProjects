using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BitAtPosition
{
    class BitAtPosition
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            string inBinary = Convert.ToString(Convert.ToInt32(userInput, 10), 2);
            Console.WriteLine("->" + inBinary);
            
            Console.Write("Enter bit position to be checked if it is '1': ");
            byte bitPos = byte.Parse(Console.ReadLine());

            int numberLen = inBinary.Length;
            
            try
            {
                bool checkBit = (inBinary[numberLen - bitPos - 1].ToString() == "1");               
                Console.WriteLine(checkBit);
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("Message = {0}", i.Message);
                Console.WriteLine("Source = {0}", i.Source);
                Console.WriteLine("Stack trace = {0}", i.StackTrace);
                Console.WriteLine("Target site = {0}", i.TargetSite);
            }
            catch (SystemException e)
            {
                Console.WriteLine("Message = {0}", e.Message);
                Console.WriteLine("Source = {0}", e.Source);
                Console.WriteLine("Stack trace = {0}", e.StackTrace);
                Console.WriteLine("Target site = {0}", e.TargetSite);                
            }
        }



    }
}
