using System;

    class ExerciseNullableType
    {
        static void Main()
        {
            int? firstNumber = null;
            Console.WriteLine("The value of the first number is: {0}!", firstNumber);

            firstNumber = 3;
            Console.WriteLine("The same number with new assigned value of 3 is equal to -> {0}!", firstNumber);
            Console.WriteLine();

            double? secondNumber = null;
            Console.WriteLine("The value of the second number is: {0}!", secondNumber);

            secondNumber = 10.5;
            Console.WriteLine("The same second number with new assigned value of 10.5 is equal to -> {0}!", secondNumber);

        }
    }

