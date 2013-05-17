using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05.GenericListT;

namespace _07.MinAndMax
{
    class MainProg
    {
        static void Main()
        {
            int[] arr = new int[] { 1, 4, -5, 10 };
            UseGenericList<int>.Min<int>();
            UseGenericList<int>.Max<int>();        
        }
    }
}
