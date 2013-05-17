using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MatrixSpiralFilling
{
    class SpiralMatrix
    {
        static void Main()
        {
            Console.Write("Enter a number (<20): ");
            int matrixSize = int.Parse(Console.ReadLine());


            while (matrixSize > 20)
            {
                Console.WriteLine("Incorrect input! Enter new number: ");
                matrixSize = int.Parse(Console.ReadLine());
            }


            int[,] cells = new int[matrixSize, matrixSize];

            for (int index = 0; index < matrixSize; index++)
            {
                cells[0, index] = (index + 1);
            }


            int x = 0;
            int y = (matrixSize - 1);
            int xDirection = 0;
            int yDirection = 0;


            int currentPosition = 0;
            int counter = 0;
            int cycleQuarterLenght = matrixSize - 1;

            for (int cellValue = matrixSize + 1; cellValue <= (matrixSize * matrixSize); cellValue++)
            {
                currentPosition++;
                
                switch (counter % 4)
                {
                    case 0: xDirection = 1; yDirection = 0; break;
                    case 1: xDirection = 0; yDirection = -1; break;
                    case 2: xDirection = -1; yDirection = 0; break;
                    case 3: xDirection = 0; yDirection = 1; break;
                }
                x += xDirection;
                y += yDirection;
                cells[x, y] = cellValue;

                if (currentPosition == cycleQuarterLenght)
                {
                    currentPosition = 0; 
                    counter++;      
                    if ((counter != 0) && (counter % 2 == 0))
                    {
                        cycleQuarterLenght--;
                    }
                }
            } 


            for (byte row = 0; row < matrixSize; row++)
            {
                for (byte col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0,3} ", cells[row, col]);
                    
                    if (col == (matrixSize - 1))
                    {
                        Console.WriteLine();
                    }
                }
            }



        }
    }
}
