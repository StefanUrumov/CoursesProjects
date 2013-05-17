using System;

    class PrintNumbers
    {
        static int index;

        static void Main()
        {
            Console.WriteLine("The required numbers are: ");
            
            for (index = 1; index < 10; index = index + 4)
            {
                ToBinary();
            }
        }

        static void ToBinary()
        {
            string inBinary = index.ToString();

            string result = Convert.ToString(Convert.ToInt32(inBinary, 10), 2);            
            Console.WriteLine(result);
        }
    
}
