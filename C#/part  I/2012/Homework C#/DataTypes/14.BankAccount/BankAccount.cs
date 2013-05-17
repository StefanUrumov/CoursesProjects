using System;

    class BankAccount
    {
        static void Main()
        {
            Console.WriteLine("As employee in our banking group You can create new bank accounts!");
            Console.WriteLine("Please enter the information needed as following: ");
            
            Console.WriteLine("1. In which bank of our group You want to create the account: ");
            string defineBank = Console.ReadLine();

            Console.WriteLine("2. Account holder first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("3. Account holder middle name: ");
            string middleName = Console.ReadLine();

            Console.WriteLine("4. Account holder family name: ");
            string familyName = Console.ReadLine();

            string holderFullName  = firstName + " " + middleName + " " + familyName;

            Console.WriteLine("5. Enter the amount of money (balance) of the account in the {0} bank: ", defineBank);
            decimal accountBalance = decimal.Parse(Console.ReadLine());

            Console.WriteLine("6. Enter the IBAN  of the account in the {0} bank: ", defineBank);
            string accountIBAN = Console.ReadLine();


            Console.WriteLine("7. Enter the BIC code of the account in the {0} bank: ", defineBank);
            string accountBIC = Console.ReadLine();

            Console.WriteLine("8. Enter the number of the first credit card associated with the bank account in {0} bank: ", defineBank);
            Console.WriteLine("(Keep in mind that the number is 16 digits long without intervals!)");

            Console.WriteLine("- Enter the number of the first credit card:");
            long creditCardNumber1 = long.Parse(Console.ReadLine());

            Console.WriteLine(" - Enter the number of the second credit card:");
            long creditCardNumber2 = long.Parse(Console.ReadLine());

            Console.WriteLine(" - Enter the number of the third credit card:");
            long creditCardNumber3 = long.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("If You filled correctly the form, Your customer is: {0} with bank account balance {1} in {2} bank and: \n bank account IBAN - {3} with BIC code - {4} \n First credit card number - {5} \n Second credit card number - {6}\n Third credit card number - {7}", holderFullName, accountBalance, defineBank, accountIBAN, accountBIC, creditCardNumber1, creditCardNumber2, creditCardNumber3);


        }
    }

