using System;
using System.Text;


    class SymbolTriangle
    {
        static void Main()
        {
            char symbol = '©';
            //Console.OutputEncoding = Encoding.UTF8; is not working properly
            Console.WriteLine("Your triangle of 9 symbols \"{0}\" is: ", symbol);
            Console.WriteLine();
            
            Console.WriteLine(" " + " " + " " + symbol + " " + " " + " " );
            Console.WriteLine(" " + " " + symbol + symbol + symbol + " ");
            Console.WriteLine(" " + symbol + symbol + symbol + symbol + symbol + " ");
            Console.WriteLine();           
        }
    }

