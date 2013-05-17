using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Employees
{
    class Program
    {
        static void Main()
        {
            int[,] m = new int[3,3] {
            {1,2,3},
            {1,2,3},
            {1,2,3}
            };

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int k = 0; k < m.GetLength(1); k++)
                {
                    //if (i != - 1)
                    //{
                    Console.Write(m[1, k]); 
                    //}                    
                }
                //Console.WriteLine();
            }



            //get rows 
            //m[ (m.GetLength(0) - 1) - i, k]

            //get cols
            //

        }
    }
}
