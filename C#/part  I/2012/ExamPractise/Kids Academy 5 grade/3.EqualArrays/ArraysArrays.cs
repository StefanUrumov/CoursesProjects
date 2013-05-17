using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EqualArrays
{
    class ArraysArrays
    {
        static void Main()
        {
            // not working properly - same numbers in first array are printed
            // if no match - print all numbers 
            Console.WriteLine("Enter number of elements for the first array: ");
            short fiArrNum = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter array elements using space (n1 n2 n3): ");
            string fiArr = Console.ReadLine();

            Console.WriteLine("Enter number of elements for the second array: ");
            short secArrNum = short.Parse(Console.ReadLine());

            Console.WriteLine("Enter array elements using space (n1 n2 n3): ");
            string secArr = Console.ReadLine();

            short counter = 0;

            string [] firstArray = fiArr.Split(' ');
            string[] secondArray = secArr.Split(' ');

            
             
            foreach (var secNum in secondArray) //read second array
            {
                //Console.Write(secNum + "*");

                for (int index = 1; index < firstArray.Length; index++) //read first array
                   {
                       //Console.Write(firstArray[index] + " "); 
                      
                       if(firstArray[index - 1] == secNum)
                       {
                           if (firstArray[index - 1] != firstArray[index])
                           {
                               counter++;
                           }                           
                       }
                       else //if (firstArray[index - 1] != secNum)
                       {
                           Console.WriteLine(firstArray[index - 1]);
                       }
                       Console.WriteLine();
                }
            }



                //for (int inner = 0; inner < secondArray.Length; inner++)
                //{
                //   Console.WriteLine(secondArray[inner]);
                //}
                
               
            
            Console.WriteLine();
            Console.WriteLine(counter + "*");
            
            




                      
        } 
    
    
    }
}
