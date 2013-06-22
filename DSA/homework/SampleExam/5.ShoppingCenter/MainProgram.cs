using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace _5.ShoppingCenter
{
    class MainProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ShoppingCenter center = new ShoppingCenter();

            StringBuilder answer = new StringBuilder();

            int commands = int.Parse(Console.ReadLine());
            for (int i = 1; i <= commands; i++)
            {
                string command = Console.ReadLine();
                string commandResult = center.ProcessCommand(command);
                answer.AppendLine(commandResult);
            }

            Console.Write(answer);
        }
    }
}

