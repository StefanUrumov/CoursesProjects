using System;

class CalculateMyAge
{
    static void Main()
    {
        Console.WriteLine("Please enter your age at this moment:");
        byte age = byte.Parse(Console.ReadLine());

        DateTime AgeInDecade = new DateTime(age, 1, 1);
        AgeInDecade = AgeInDecade.AddYears(10);

        Console.WriteLine("After a decade you will be {0} years old!", AgeInDecade.Year);
    }
}
