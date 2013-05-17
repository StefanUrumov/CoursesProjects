using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericListT
{
    class MainProg
    {        
        static void Main()
        {
            int[] arr = new int[]{2, 4, 6 ,8, 9, 10, 7, 8, 9, 1};
            foreach (var item in arr)
            {
                Console.Write(" " + item); 
            }
            //UseGenericList<int[]>.Insert(arr, 3);
            //UseGenericList<int[]>.Remove(2);
            UseGenericList<int[]>.Clear();
        }
    }
}
