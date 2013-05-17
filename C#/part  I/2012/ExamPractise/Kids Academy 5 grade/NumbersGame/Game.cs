using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame
{
    class Game
    {
        static void Main()
        {
            Console.WriteLine("Enter a 4 - digits number: ");
            string numberStr = Console.ReadLine();

            string newNumber = numberStr[1].ToString() + numberStr[0].ToString() + numberStr[3].ToString() + numberStr[2].ToString();
            int result = int.Parse(numberStr) + int.Parse(newNumber);
            Console.WriteLine(result);
        }
    }
}
