using System;

    class PrintFullName
    {
        static string firstName;
        static string lastName;

        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            PrintMyName();
            Console.WriteLine();
        }

        static void PrintMyName()
        {
            Console.Write("Hello! My name is {0} {1}!", firstName, lastName);            
        }
    }

