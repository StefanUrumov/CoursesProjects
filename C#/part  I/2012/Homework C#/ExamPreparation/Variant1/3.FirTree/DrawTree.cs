using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.FirTree
{
    class DrawTree
    {
        static void Main()
        {
            
            byte treeHeigth = byte.Parse(Console.ReadLine());
            char elements = ' ';

            for (int top = 1; top <= ((treeHeigth - 2) * 2); top++)
            {
                elements = '.';
                Console.Write(elements);
                if (top == treeHeigth - 2)
                {
                    elements = '*';
                    Console.Write(elements);
                }
            }
            Console.WriteLine();
            for (int row = 1; row <= treeHeigth - 3; row++)
            {
                for (int col = 1; col <= ((treeHeigth - 2) * 2) + 1; col++)
                {
                    elements = '.';
                    if (col >= ((((treeHeigth - 2) * 2) + 1) / 2) - (row - 1) && col <= ((((treeHeigth - 2) * 2) + 1) / 2) + row + 1)
                    {
                        elements = '*';
                    }
                    Console.Write(elements);
                }
                Console.WriteLine();
            }
            for (int last = 1; last <= ((treeHeigth - 2) * 2) + 1; last++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
            for (int stem = 1; stem <= ((treeHeigth - 2) * 2); stem++)
            {
                elements = '.';
                Console.Write(elements);
                if (stem == treeHeigth - 2)
                {
                    elements = '*';
                    Console.Write(elements);
                }
            }
            Console.WriteLine();
        }
    }
}
