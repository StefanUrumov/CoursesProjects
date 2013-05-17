using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class UseDictionary
    {
        static void Main()
        {
            string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes"};

            string search = "CLR";//Console.ReadLine();
            
            foreach (string line in dictionary)
            {
                if (line.IndexOf(search + " -") == 0)
                {
                    Console.WriteLine(line);
                }                
            }

        }
    }
}
