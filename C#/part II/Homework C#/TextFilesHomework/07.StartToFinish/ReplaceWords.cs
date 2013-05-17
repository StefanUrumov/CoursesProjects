using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.StartToFinish
{
    class ReplaceWords
    {
        //output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // Exercise 8
        static void Main()
        {
            using (StreamReader inputFile = new StreamReader("../../test.txt"))
            {
                using (StreamWriter outputFile = new StreamWriter("../../result.txt"))
                {
                    string line = string.Empty;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        outputFile.WriteLine(line.Replace("start", "finish"));                        
                    }
                }
            }
        }
    }
}
