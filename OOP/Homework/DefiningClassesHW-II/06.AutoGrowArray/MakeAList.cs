using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.GenericListT;

namespace _06.AutoGrowArray
{
    class MakeAList 
    {
        static void Main()
        {
            int [] arr =  new int[]{2, 4, 5};
            UseGenericList<int[]>.AutoGrow();
            Console.WriteLine(arr.Length);
        }
    }
}
