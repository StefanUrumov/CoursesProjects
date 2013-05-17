using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangeBits
{
    class ExchangeBits
    {
        static int userInput;
        static long bit3;
        static long bit4;
        static long bit5;
        static long bit24;
        static long bit25;
        static long bit26;
        static string newBinaryNum;
        

        static void Main()
        {
            Console.WriteLine("Enter a number (must be 32-bit unsigned): ");
            userInput = int.Parse(Console.ReadLine());

            GetBits();

            PrintFinalNumber();
        }

        static void GetBits()
        {
            int p3 = 3;
            long mask3 = 1 << p3;
            long nAndmask3 = userInput & mask3;
            bit3 = nAndmask3 >> p3;
            Console.WriteLine("The 3th bit of your number is: {0}", bit3);

            int p4 = 4;
            long mask4 = 1 << p4;
            long nAndmask4 = userInput & mask4;
            bit4 = nAndmask4 >> p4;
            Console.WriteLine("The 4th of your number is: {0}", bit4);

            int p5 = 5;
            long mask5 = 1 << p5;
            long nAndmask5 = userInput & mask5;
            bit5 = nAndmask5 >> p5;
            Console.WriteLine("The 5th of your number is: {0}", bit5);

            int p24 = 24;
            long mask24 = 1 << p24;
            long nAndmask24 = userInput & mask24;
            bit24 = nAndmask24 >> p24;
            Console.WriteLine("The 24th of your number is: {0}", bit24);

            int p25 = 25;
            long mask25 = 1 << p25;
            long nAndmask25 = userInput & mask25;
            bit25 = nAndmask25 >> p25;
            Console.WriteLine("The 25th of your number is: {0}", bit25);

            int p26 = 26;
            long mask26 = 1 << p26;
            long nAndmask26 = userInput & mask26;
            bit26 = nAndmask26 >> p26;
            Console.WriteLine("The 26th of your number is: {0}", bit26);

            ExchangeBitPositions();
           
        }

        static void ExchangeBitPositions()
        {
            bit3 = bit3 + bit24;
            bit24 = bit3 - bit24;
            bit3 = bit3 - bit24;
            Console.WriteLine("After the Exchange ");
            Console.WriteLine("bit3 is: {0} and bit24 is: {1}", bit3, bit24);

            bit4 = bit4 + bit25;
            bit25 = bit4 - bit25;
            bit4 = bit4 - bit25;
            Console.WriteLine("bit4 is: {0} and bit25 is: {1}", bit4, bit25);

            bit5 = bit5 + bit26;
            bit26 = bit5 - bit26;
            bit5 = bit5 - bit26;
            Console.WriteLine("bit5 is: {0} and bit26 is: {1}", bit5, bit26);         
            
        }

        static void PrintFinalNumber()
        {           

            string toBinary = userInput.ToString();
            string inBinary = Convert.ToString(Convert.ToInt32(toBinary, 10), 2);

            Console.WriteLine("Your original number in binary is: \n {0}", inBinary);
            
            int binLen = inBinary.Length - 1;            

            if (binLen < 32)
            {
                int newLen = 32 - binLen;                
                newBinaryNum = inBinary.PadLeft(newLen, '0').ToString();                
                inBinary = newBinaryNum;
            }

            string swap = SwapCharacters(inBinary);
            Console.WriteLine("Your new number in binary is: \n {0}", swap);

            string toDecimal = Convert.ToString(Convert.ToInt32(swap, 2), 10);
            Console.WriteLine("In decimal is: \n {0}!", toDecimal);
        }

        static string SwapCharacters(string inBinary)
        {
            long numLen = inBinary.Length - 1;

            long position3 = numLen - 3;
            long position4 = numLen - 4;
            long position5 = numLen - 5;
            long position24 = numLen - 24;
            long position25 = numLen - 25;
            long position26 = numLen - 26;


            char[] array = inBinary.ToCharArray(); 

            char temp = array[position3]; 
            array[position3] = array[position24]; 
            array[position24] = temp;

            char temp1 = array[position4];
            array[position4] = array[position25];
            array[position25] = temp1;

            char temp2 = array[position5];
            array[position5] = array[position26];
            array[position26] = temp2; 

            return new string(array); 
        }

        
    }
}