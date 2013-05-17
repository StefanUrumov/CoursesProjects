using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3.CrossWords
{
    class SomeWords
    {
        static void Main()
        {

            Console.BufferHeight = Int16.MaxValue - 1;

            //can use labirynth logic - move forward and down
            
            string size = Console.ReadLine();
            
            bool isRow = false;
            byte rows = 0;
            isRow = byte.TryParse(size[0].ToString(), out rows);                       

            string currentInput = "";
            string currentAll = "";
            string [] inputArr = new string [] {};

            for (int i = 0; i < rows; i++)
            {
                currentInput = Console.ReadLine();
                string[] horiz = currentInput.Split('#');

                foreach (var item in horiz)
                {
                    if (item.Length > 1)
                    {
                        currentAll += item;
                        currentAll += " ";
                    }                    
                }                
                //currentAll += " ";  
            }
                        

            Console.WriteLine("----------------------------");
            Console.WriteLine(currentAll);


            string[] horizontal = currentAll.Split(' ');
            
            Array.Sort(horizontal);

            //foreach (var item in horizontal)
            //{
            //    Console.Write(item + " ");
            //}


            string final  = " ";
            for (int i = 0; i < horizontal.Length; i++)
            {
                //if (i == 1)
                //{
                //   break; 
                //}
                if(i == 0)
                {
                    final = horizontal[i];
                }                                                        
            }

            string addFinal = horizontal.Last().ToString();
            addFinal = horizontal.First().ToString();

            Console.WriteLine(final);

            //find horizontal words order
        }
    }
}
