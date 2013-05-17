using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.SquareMatrixSum
{
    class FindSum
    {
        static int[,] numArr;

        static void Main()
        {
            string path1 = "../../test.txt";
            string result = "../../result.txt";

            PrintMatrix(path1);

            FindBestFileSum(path1, result);
        }

        private static int FindMaxSum(int[,] numArr)
        {

            int bestSum = int.MinValue;
            int currentSum = 0;

            for (int row = 0; row < numArr.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < numArr.GetLength(1) - 1; col++)
                {
                    currentSum = numArr[row, col] + numArr[row, col + 1] +
                                 numArr[row + 1, col] + numArr[row + 1, col + 1];
                    if (bestSum < currentSum)
                    {
                        bestSum = currentSum;
                    }
                    currentSum = 0;
                }
            }
            return bestSum;
        }

        private static void FindBestFileSum(string path1, string result)
        {
            string line = string.Empty;
            string num = string.Empty;
            int matrixSize = 0;
            int row = 0;
            int col = 0;

            using (StreamReader sr = new StreamReader(path1))
            {
                line = sr.ReadLine();
                matrixSize = int.Parse(line);
                numArr = new int [matrixSize, matrixSize];

                while ((line = sr.ReadLine()) != null)
                {
                    foreach (var item in line)
                    {
                        if (item != ' ')
                        {
                            num += item;
                        }
                        else
                        {
                            numArr[row, col] = int.Parse(num);
                            num = string.Empty;
                            col++;
                        }
                        numArr[row, col] = int.Parse(num);
                        col = 0;
                        row++;
                        num = string.Empty;
                    }
                }



                using (StreamWriter write = new StreamWriter(result))
                {
                    write.WriteLine( FindMaxSum(numArr));
                }
            }

        }

        private static void PrintMatrix(string path1)
        {
            StreamReader fiFile = new StreamReader(path1);

            string first = fiFile.ReadToEnd();
            Console.WriteLine("Matrix from the file: ");
            Console.WriteLine(first);
        }


    }
}
