using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigAndZag
{
    class ZigZag
    {
        static void Main()
        {
            Console.WriteLine("Enter how many number you want in your sequence (0 <= number <= 50)");
            byte N = byte.Parse(Console.ReadLine());
                        
            int [] arr = new int [N];

            for (int index = 0; index < N; index++) //read numbers - fill array
            {
                Console.WriteLine("enter {0} number: ", index); //can check the next number with while loop
                arr[index] = byte.Parse(Console.ReadLine());    //using the putBigger - putSmaller logic            
            }

            
            for (int index = 0; index < N; index++ ) //print numbers in array
            {
                Console.Write(arr[index] + " ");
                
            }
            Console.WriteLine();
           
            int len = 0;
            int bestLen = len;
            
            int length = arr.Length;

            for (int index = 1; index < length - 1; index++)
            {
                if (arr[index] > arr[index - 1])
                {                    
                    len++;                              // len is not counted correctly (bigger)
                    arr[index] = arr[index - 1];
                    if (arr[index] < arr[index - 1])
                    {
                        len++; 
                    }                    
                }
                else
                {                    
                    len = 0;
                }
                if (len > bestLen)
                {  
                    /*
                    if (bestLen < len)
                    {
                        bestLen = len;                        
                    }
                     * */
                    bestLen = len;  
                   // bestLen++;      
                }
            }
            Console.WriteLine("Max Sequence is: {0} ", bestLen);

        }
    }
}
