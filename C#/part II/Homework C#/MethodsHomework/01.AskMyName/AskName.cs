using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AskMyName
{
    class AskName
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            SayHello(userName);
        }

        private static string SayHello(string userName)
        {
            Console.WriteLine("Hello, {0}!", userName);
            return userName;
        }
    }
}
