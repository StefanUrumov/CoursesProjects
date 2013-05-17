using System;

    class ExchangeValues
    {        

        static void Main()
        {
            int firstValue = 5;
            int secondValue = 10;

            Console.WriteLine("If your numbers are {0} and {1}!", firstValue, secondValue);

            firstValue = firstValue + secondValue;
            secondValue = firstValue - secondValue;
            firstValue = firstValue - secondValue;

            Console.WriteLine("After the exchange the values are {0} and {1}!", firstValue, secondValue);
        }
        
    }

