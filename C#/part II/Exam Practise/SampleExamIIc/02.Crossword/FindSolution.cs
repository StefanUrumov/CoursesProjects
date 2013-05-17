using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Crossword
{
    class FindSolution
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            //List<string> list = new List<string>();
            string list = string.Empty;

            for (int i = 0; i < size*2; i++)
            {
                //list.Add(Console.ReadLine());    
                list += Console.ReadLine();
            }

            string[,] table = new string[,] { };

            for (int i = 0; i < list.Length; i++)
            {
               for (int row = 0; row < size; row++)
               {
                   for (int col = 0; col < size; col++)
                   {
                     table[row, col] = list[i].ToString();
                   }
               }
            }

            
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write(table[row, col]);
                }
                Console.WriteLine();
            }

            
            
            Console.ReadLine();
        }
    }
}
