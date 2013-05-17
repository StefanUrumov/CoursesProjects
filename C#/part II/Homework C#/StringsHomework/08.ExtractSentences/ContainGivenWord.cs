using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class ContainGivenWord
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            //Console.WriteLine("If this is our text:");
            //Console.WriteLine(text);

            string[] sentences = text.Split('.');
            string final = string.Empty;

            string word = " in ";
            
            foreach (var item in sentences)
            {
                //Console.WriteLine(item);
                for (int i = 0; i < item.Length - 1; i++)
                {
                    if (item.IndexOf(word) != -1)
                    {
                        final += item + "\n";
                    }                   
                }
            }
            Console.WriteLine(final);
            

            
           
        

        }
    }
}
