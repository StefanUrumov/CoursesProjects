using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.GiftCard
{
    class GiftCard
    {
        static void Main()
        {
            //maybe faster if string is used
            Console.WriteLine("Enter number for a leaf:");
            char a = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine("Enter number for stalk");
            char b = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.WriteLine("  #*#");
            Console.WriteLine("  ***");
            Console.WriteLine("  #*#");
            Console.WriteLine("   {0}", b);
            for (int row = 1; row < 4; row++)
            {
                for (int col = 1; col <=7; col++)
                {
                    if (col == 4)
                    {
                        Console.Write(b);
                    }
                    if (col == row || col == 7 - row)
                    {
                        Console.Write(a);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }



        }
    }
}
