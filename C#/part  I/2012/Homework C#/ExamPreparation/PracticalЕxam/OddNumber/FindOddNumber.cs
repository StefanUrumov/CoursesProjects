using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class FindOddNumber
    {
        static void Main()
        {   
            int N = int.Parse(Console.ReadLine());

            long[] arr = new long[N];
            for (int index = 0; index < N; index++)
            {
                long num = long.Parse(Console.ReadLine());
                arr[index] = num;
            }
            Array.Sort(arr);

            //foreach (var numbers in arr)
            //{
            //    Console.Write(numbers + " ");                               
            //}
            //Console.WriteLine();


            int len = 1;             
            long bestStart = arr[0];
            
            
            for (int indexInner = 0; indexInner < arr.Length - 1; indexInner++)
            {
                if (arr[indexInner] == arr[indexInner + 1])
                { 
                    len++;                    
                    
                    if (len % 2 != 0)  
                    {                   
                        bestStart = arr[indexInner];
                    }
                }
                else
                {
                    len = 1;
                    if (arr[indexInner] != arr[indexInner + 1]&& arr[indexInner] != arr[indexInner - 1])  
                    {
                        bestStart = arr[indexInner];
                        break;
                    }
                    //else if (bestStart < arr[arr.Length - 1])
                    //{
                    //    bestStart = arr[arr.Length - 1];
                    //    break;
                    //}
                    
                    
                }                
            }
            //Console.WriteLine("The number with odd occurrence in this array is: ");
            Console.WriteLine(bestStart);            
        }
    }
}
