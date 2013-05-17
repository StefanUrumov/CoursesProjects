using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BottleMessages
{
    class ReadMessage
    {
        static void Main()
        {
            string code = Console.ReadLine();
            string key = Console.ReadLine();

            char[] separatorsAlpfa = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string[] numberKey = key.Split(separatorsAlpfa, StringSplitOptions.RemoveEmptyEntries); 
            
            //get numbers
            foreach (var item in numberKey)
            {
                //Console.Write("{0} ", item);
            }

            Console.WriteLine();
            
            //get letters
            string letterKey = string.Empty;

            for (int i = 0; i < key.Length; i++)
            {
                if (char.IsLetter(key[i]))
                {
                    letterKey += key[i];
                }
            }
            //Console.WriteLine(letterKey);

            int comboCount = 0;
            string bestFound = string.Empty;

            //get num key
            for (int i = 0; i < code.Length; i++)
            {
                for (int k = 0, y = 0; k < numberKey.Length && y < letterKey.Length; k++, y++)
                {
                    if (code[i].ToString() == numberKey[k])
                    {                                               
                        //Console.Write(letterKey[y]);
                        bestFound += letterKey[y];
                    }                    
                }
                
            }

            Console.WriteLine(comboCount);
            Console.WriteLine(bestFound);
        
        
        
        }
    }
}
