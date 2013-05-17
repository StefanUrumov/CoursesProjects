using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WrongOrder
{
    class UnOrder
    {
        //not working properly 
        // arr[2] always must be input
        // arr[1] = previous input
        // arr[0] =  pre-previous input

        static byte input;
     
        static void Main()
        {
            while (true)
            {
                byte counter = 0;
                
                byte[] arr = new byte[4];
                
               for (int index = 1; index < arr.Length ; index++)
               {
                   input = byte.Parse(Console.ReadLine());
                   arr[index - 1] = input;
                   if (arr[index] == arr[2])
                   {
                       arr[2] = 0; // or = input  
                                        //arr[index] = arr[index - 1];
                        
                   }                  

                   Console.Write(arr[0] + " " + arr[1] + " " + arr[2]);
                   Console.WriteLine();
                   
                   if ( arr[1] > arr[0] && arr[1] > arr[2])
                   {
                       counter++;                                                                      
                   }
               }

               
                if (input == 0 || input > 200)
                {
                    Console.WriteLine(counter + "+");
                    break;
                }
            }

            



        }
    }
}
