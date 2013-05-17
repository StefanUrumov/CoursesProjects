using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.User_sChoice
{
    class Choice
    {
        static void Main()
        {
            Console.WriteLine("Choose from below:");
            Console.WriteLine("0 for int");
            Console.WriteLine("1 for double");
            Console.WriteLine("2 for string");
            Console.WriteLine("And press Enter!");
            byte userInput = byte.Parse(Console.ReadLine());

            
                switch(userInput)
                {
                    case 0:
                        Console.WriteLine("Enter an integer:");
                        int userInt = int.Parse(Console.ReadLine());
                        Console.WriteLine("The new result is: {0}", userInt + 1);break;
                    case 1:
                        Console.WriteLine("Enter a double: ");
                        double userDouble = double.Parse(Console.ReadLine());
                        Console.WriteLine("The new result is: {0}", userDouble + 1);break;
                    case 2:
                        Console.WriteLine("Enter your string:");
                        string userStr = Console.ReadLine();
                        Console.WriteLine(" The new result is: {0}*", userStr);break;
                    default:            
                    Console.WriteLine("Incorrect input!");break;
            }

        }
    }
}
