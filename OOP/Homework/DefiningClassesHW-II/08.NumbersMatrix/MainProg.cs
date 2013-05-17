using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersMatrix
{
    class MainProg
    {
        static void Main()
        {
            int[,] matrix1 = new int[,]
            {
                {1, 2, -3},
                {2, 1, 3},
                {3, 1, 2}
            };

            int[,] matrix2 = new int[,]
            {
                {4, 5, 6},
                {-1, 0, 7},
                {3, 2, 1}
            };

            Matrix<int> m1 = new Matrix<int>(matrix1);
            Matrix<int> m2 = new Matrix<int>(matrix2);

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 - m2);
            Console.WriteLine(m1 * m2);
            Console.WriteLine(m1.Transpose());
            Console.WriteLine(m1 * 5);

        }
    }
}
