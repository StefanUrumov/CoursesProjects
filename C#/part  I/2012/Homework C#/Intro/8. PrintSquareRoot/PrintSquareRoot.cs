using System;

    class PrintSquareRoot
    {
        static int number;
        static double result;
         
        static void Main()
        {
            Console.WriteLine("If your number is: 12345");
            
            Console.WriteLine("The square is: ");
            number = 12345;
            CalculateSquare();

        }

        static void CalculateSquare()
        {            
            result =  Math.Sqrt(number);
            Console.WriteLine(result);
        }
    }

