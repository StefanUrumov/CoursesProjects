using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompareTwoCharArrays
{
    class DoComparison
    {
        static char[] firstArray;
        static char[] secondArray;
        static bool equality;

        static void Main()
        {
            firstArray = new char[] { 'r', 'd', 't', 'n', 'm', 'q', 'a', 'g'};
            secondArray = new char[] { 'r', 'd', 't', 'n', 'm', 'q', 'i', 'q' };

            equality = true;

            for (int index = 0, index2 = 0; index < firstArray.Length && index2 < secondArray.Length; index++, index2++)
            {                
                if (firstArray[index] != secondArray[index2])
                {
                    if (firstArray[index] < secondArray[index2])
                    {
                        Console.WriteLine("The first array is earlier lexicographicaly!");
                        equality = false;
                        break;
                    }
                    if (firstArray[index] > secondArray[index2])
                    {
                        Console.WriteLine("The second array is earlier lexicographicaly!");
                        equality = false;
                        break;
                    }
                }
            }

            if (equality == true)
            {
                ChecArraysLength();
                                
          }
            
            
    }

        private static void ChecArraysLength()
        {
            int lengthFi = firstArray.Length;
            int lengthSe = secondArray.Length;


            for (int index = 0, index2 = 0; index < firstArray.Length && index2 < secondArray.Length; index++, index2++)
            {
                if (firstArray[index] == secondArray[index2])
                {
                    if (lengthFi < lengthSe)
                    {
                        Console.WriteLine("The first array is earlier lexicographicaly!");
                        break;
                    }
                    if (lengthFi > lengthSe)
                    {
                        Console.WriteLine("The second array is earlier lexicographicaly!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Two arrays are equal lexicographicaly!");
                        break;
                    }
                }
            }
        }
  }
}
