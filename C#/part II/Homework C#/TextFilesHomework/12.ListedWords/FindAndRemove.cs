using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12.ListedWords
{
    class FindAndRemove
    {
        static void Main()
        {
            string path1 = "../../test.txt";
            string path2 = "../../result.txt";
            
            try
            {
                var words = File.ReadAllLines(path1, Encoding.Default);
                using (StreamReader reader = new StreamReader(path1, Encoding.Default))
                {
                    using (StreamWriter writer = new StreamWriter(path2))
                    {
                        while (!reader.EndOfStream)
                        {
                            StringBuilder line = new StringBuilder(reader.ReadLine());
                            StringBuilder buffer = new StringBuilder();
                            for (int i = 0; i < line.Length; i++)
                            {
                                char ch = line[i];
                                if (!char.IsLetter(ch))
                                {
                                    if (words.Contains(buffer.ToString()))
                                    {
                                        line.Remove(i - buffer.Length, buffer.Length);
                                        i -= buffer.Length;
                                    }
                                    buffer.Clear();
                                }
                                else
                                {
                                    buffer.Append(ch);
                                }
                            }
                            writer.WriteLine(line.ToString());
                        }
                    }
                }    
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Message  = {0}", fnfe.Message);
                Console.WriteLine("Source  = {0}", fnfe.Source);
                Console.WriteLine("Stack trace  = {0}", fnfe.StackTrace);
                Console.WriteLine("Target site  ={0}", fnfe.TargetSite);
            }
            catch (FieldAccessException fae)
            {
                Console.WriteLine("Message  = {0}", fae.Message);
                Console.WriteLine("Source  = {0}", fae.Source);
                Console.WriteLine("Stack trace  = {0}", fae.StackTrace);
                Console.WriteLine("Target site  ={0}", fae.TargetSite);
            }
            catch (FileLoadException fle)
            {
                Console.WriteLine("Message  = {0}", fle.Message);
                Console.WriteLine("Source  = {0}", fle.Source);
                Console.WriteLine("Stack trace  = {0}", fle.StackTrace);
                Console.WriteLine("Target site  ={0}", fle.TargetSite);
            }
        }

    }
}
