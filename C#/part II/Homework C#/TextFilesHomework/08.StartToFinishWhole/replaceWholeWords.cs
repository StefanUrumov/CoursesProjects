using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _08.StartToFinishWhole
{
    class replaceWholeWords
    {        
        static void Main()
        {
            using (StreamReader inputFile = new StreamReader("../../test.txt"))
            {
                using (StreamWriter outputFile = new StreamWriter("../../result.txt"))
                {
                    string line = string.Empty;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        outputFile.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); 
                    }
                }
            }
        }
    }
}
