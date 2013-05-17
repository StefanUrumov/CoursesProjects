using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Matrix
{
    class MatrixCube
    {
        static void Main()
        {
            Console.Write("Enter a number (<20): ");
            byte userInput = byte.Parse(Console.ReadLine());
            
            
            while (userInput > 20)
            {
                Console.WriteLine("Incorrect input! Enter new number: ");
                userInput = byte.Parse(Console.ReadLine());
            }

            byte [,] cube = new byte [userInput, userInput];


            for (int row = 1; row <= userInput; row++)
            {

                for (int col = row; col < row + userInput; col++)
                {
                    
                    Console.Write(" " + col);
                }
                Console.WriteLine();
            }









        }
    }
}
