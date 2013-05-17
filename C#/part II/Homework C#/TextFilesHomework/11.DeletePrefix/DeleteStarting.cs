using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;


namespace _11.DeletePrefix
{
    class DeleteStarting
    {
        static void Main()
        {
            string fileName = "test.txt";
            string resultFileName = "result.txt";
                      
            using (StreamWriter writer =new StreamWriter(resultFileName))
            {
                using(StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadToEnd();
                    while (line != null)
                    {
                        line = Regex.Replace(line, @"(\b)test((\d|\w|_)*)(\b)", " ");
                        writer.WriteLine(Regex.Replace(line, @"(\s){2,}", " "));
                        line = reader.ReadLine();                 
                    }
                }
            }
            Process openFile = new Process();
            openFile.StartInfo.FileName = fileName;
            openFile.Start();

            openFile.StartInfo.FileName = resultFileName;
            openFile.Start();    
        }




    }
}
