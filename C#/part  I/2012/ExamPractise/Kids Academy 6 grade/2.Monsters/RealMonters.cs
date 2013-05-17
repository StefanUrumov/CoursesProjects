using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Monsters
{
    class RealMonters
    {
        static void Main()
        {
            //incorrect output - bigger score

            Console.WriteLine("Enter table length and table width usig space (8 5) between 1 and 106");
            string table = Console.ReadLine();

            int length = int.Parse(table[0].ToString());
            int width = int.Parse(table[2].ToString());

            Console.WriteLine("Enter number of monsters (1..103): ");
            byte monsters = byte.Parse(Console.ReadLine());

            int steps = 0;
            int finalSteps = 0;

            Console.WriteLine("Enter monsters coordinates (x y) and (using space) then direction N/E/S/W: ");
            for (int index = 0; index < monsters; index++)
            {
                string current = Console.ReadLine();
                int x = int.Parse(current[0].ToString());
                int y = int.Parse(current[2].ToString());
                char direction = current[4];

                switch (direction)
                {
                    case 'N':
                        steps = (width - y) + 1;                        
                        break;
                    case 'E':
                        steps = (length - x) + 1;
                        break;
                    case 'S':
                        steps = width - (width - y);
                        break;
                    case 'W':
                        steps = length - (length - x);
                        break;
                    default:
                        break;
                }
                finalSteps += steps;
            }
            Console.WriteLine(finalSteps);
        }
    }
}
