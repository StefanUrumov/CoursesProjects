using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitArray
{
    class BitArray
    {
        static int userInput = new int();
        static int p = new int();
        static int q = new int();
        static int k = new int(); 

        static void Main()
        {            
            bool valid = false;
            while (valid == false)
            {
                Console.Write("Please enter a number:");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }
            valid = false;
            while (valid == false)
            {
                Console.Write("Enter a number of bits for exchanging. k (2 - 31) = ");
                try
                {
                    k = int.Parse(Console.ReadLine());
                    valid = true;
                    if ((k <= 1) || (k > 31))
                    {
                        Console.WriteLine("Please enter a number between 2 and 31!");
                        valid = false;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }
            int topLimit = 32 - (k * 2);
            valid = false;
            while (valid == false)
            {
                Console.Write("First number of the first array of {0} bits for exchanging. p (0 - {1}) = ", k, topLimit);
                try
                {
                    p = int.Parse(Console.ReadLine());
                    valid = true;
                    if ((p < 0) || (p > topLimit))
                    {
                        Console.WriteLine("Please enter a number between 1 and 31!");
                        valid = false;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }

            int downLimit = p + k;
            valid = false;
            while (valid == false)
            {
                Console.Write("First number of second array of {0} bits for exchanging. q ({1} - {2}) = ", k, downLimit, topLimit);
                try
                {
                    q = int.Parse(Console.ReadLine());
                    valid = true;
                    if ((q < downLimit) || (q > topLimit))
                    {
                        Console.WriteLine("Please enter a number between {0} and {1}!", downLimit, topLimit);
                        valid = false;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
                catch (ArgumentNullException) 
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }
            int[] arrayFirstSetOfBits = new int[k-1];
            int[] arraySecondSetOfBits = new int[k-1];
            for (int i = 0; i < k - 1; i++)
            {
                arrayFirstSetOfBits[i] = (((1 << p) & userInput) != 0) ? 1 : 0;
                arraySecondSetOfBits[i] = (((1 << q) & userInput) != 0) ? 1 : 0;
                if (arrayFirstSetOfBits[i] != arraySecondSetOfBits[i])
                {
                    if (arraySecondSetOfBits[i] == 1)
                    {
                        userInput = userInput | (1 << p);
                        userInput = userInput & (~(1 << q));
                    }
                    else
                    {
                        userInput = userInput | (1 << q);
                        userInput = userInput & (~(1 << p));
                    }
                }
                p = p + 1;
                q = q + 1;
            }

            Console.WriteLine("Exchanged bits number is: {0}", userInput);
        }
    }
}
