using System;

    class PrintSequence
    {
        static void Main()
        {
            string members = "2, -3, 4, -5, 6, -7";
            Console.WriteLine("If your sequence of numbers is: {0}", members);
            
            Console.WriteLine("The first 10 members are:");

            for (int index = 2; index <= 11; index = index + 2) 
            {
                Console.Write("{0}, -{1}, ", index, index + 1);
            }
            Console.WriteLine();
        }
    }

