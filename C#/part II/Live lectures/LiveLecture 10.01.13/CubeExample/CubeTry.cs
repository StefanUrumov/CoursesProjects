using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeExample
{
    class CubeTry
    {
        static void Main()
        {
            //create the cube
            int[] dimentions = { 0, 0, 0 };
            dimentions[0] = int.Parse(Console.ReadLine());
            dimentions[1] = int.Parse(Console.ReadLine());
            dimentions[2] = int.Parse(Console.ReadLine());

            int[, ,] array = new int[dimentions[0],
                                    dimentions[1],
                                    dimentions[2]];

            //populate cube
            for (int index1 = 0; index1 < array.GetLength(0); index1++)
            {
                for (int index2 = 0; index2 < array.GetLength(1); index2++)
                {
                    for (int index3 = 0; index3 < array.GetLength(2); index3++)
                    {
                        Console.WriteLine("array [{0}, {1}, {2}] = ", index1, index2, index3);
                        array[index1, index2, index3] = int.Parse(Console.ReadLine());
                    }
                }
            }


            //print the cube
            for (int index1 = 0; index1 < array.GetLength(0); index1++)
            {
                for (int index2 = 0; index2 < array.GetLength(1); index2++)
                {
                    for (int index3 = 0; index3 < array.GetLength(2); index3++)
                    {
                        Console.WriteLine(" {0} ", array[index1, index2, index3]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
