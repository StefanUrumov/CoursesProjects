using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.WordsMED
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string wordOne = "developer";
            string wordTwo = "enveloped";

            WordsMEDCalculator.GetCost(wordOne, wordTwo);
        }
    }
}
