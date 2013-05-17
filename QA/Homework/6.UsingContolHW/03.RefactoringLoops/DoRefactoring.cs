using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RefactoringLoops
{
    class DoRefactoring
    {
        static void Main()
        {
            int[] numbersArray = new int[100];            
            int expectedValue = 667;
            int divider = 10;
            bool valueFound = false;

            for (int index = 0; index < numbersArray.Length; index++)
            {
                Console.WriteLine(numbersArray[index]);
                if ((index % divider == 0) && (numbersArray[index] == expectedValue))
                {
                    valueFound = true;
                    break;
                }
            }

            if (valueFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
