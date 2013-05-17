using System;

    class MarketingCompany
    {
        static void Main()
        {
            Console.WriteLine("Tell us who are you in our Marketing Company. Please enter: ");
            Console.Write("Your first name:");
            string firstName = Console.ReadLine();

            Console.Write("Your family name:");
            string familyName = Console.ReadLine();

            Console.Write("Your age: ");
            byte employeeAge = byte.Parse(Console.ReadLine());

            Console.Write("Your gender M(male) or F(female): ");
            string employeeGender = Console.ReadLine();

            if (employeeGender == "M" || employeeGender == "m")
            {
                 employeeGender = "male";
            }
            else if (employeeGender == "F" || employeeGender == "f")
            {
                employeeGender = "female";
            }
            else
            {
                Console.WriteLine("Incorrect input! Please try again!"); return;
            }

            Console.Write("Enter the last 4 digits of Your ID number (27 56 /0 000 to 27 56 /9 999): ");
            ushort employeeID = ushort.Parse(Console.ReadLine());

            if (employeeID < 0 || employeeID > 10000)
            {
                Console.WriteLine("Incorrect ID! Please try again!");
            }
            else
            {
                Console.WriteLine("As our employee you are: {0} {1}, {2} years old, {3}, with ID - {4}!", firstName, familyName, employeeAge, employeeGender, 27560000 + employeeID);
            }
                        
        }
    }

