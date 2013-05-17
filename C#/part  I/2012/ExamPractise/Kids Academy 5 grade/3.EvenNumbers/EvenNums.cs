using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EvenNumbers
{
    class EvenNums
    {       
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');             
            int isNumber = 0;
            int biggestEven = 0;
         

            for (int index = 0; index < words.Length; index++)
            {
                //Console.WriteLine(words[index]);
                if (int.TryParse(words[index], out isNumber))
                {
                    //Console.WriteLine(isNumber);  

                    if (isNumber % 2 == 0)
                    {
                        //Console.WriteLine(isNumber); // get the even numbers in text
                        int[] evenNums = new int [isNumber];
                        for (int inner = 0; inner < evenNums.Length; inner++)
                        {
                            evenNums[inner] = isNumber;
                        }
                        Array.Sort(evenNums);
                        for (int biggest = 0; biggest < evenNums.Length; biggest++)
                        {
                            biggestEven = evenNums[evenNums.Length - 1];
                        }
                    }
                }
            }
            if (biggestEven == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(biggestEven);
            }
            
        }
    }
}
