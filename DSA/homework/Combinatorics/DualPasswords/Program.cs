
namespace DualPasswords
{
    using System;
    using System.Linq;

    class Program
    {
       static void Main()
        {
            string password = Console.ReadLine();
            int unknownNumbers = 0;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '*')
                {
                    unknownNumbers++;
                }
            }

            ulong result = 1;
            for (int i = 1; i <= unknownNumbers; i++)
			{
                result <<= 1;
			}

            Console.WriteLine(result);
        }
    }
}
