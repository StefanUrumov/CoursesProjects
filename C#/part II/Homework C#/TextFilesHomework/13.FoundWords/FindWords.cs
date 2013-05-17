using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _13.FoundWords
{
    class FindWords
    {
        static void Main()
        {
            string path1 = "../../test.txt";
            string path2 = "../../words.txt";
            string path3 = "../../result.txt";

            try
            {
                var words = File.ReadAllLines(path2, Encoding.Default).ToDictionary(line => line, line => 0);
                using (StreamReader reader = new StreamReader(path1, Encoding.Default))
                {
                    while (!reader.EndOfStream)
                    {
                        StringBuilder buffer = new StringBuilder();
                        foreach (char ch in reader.ReadLine())
                        {
                            if (!char.IsLetter(ch))
                            {
                                if (words.ContainsKey(buffer.ToString()))
                                {
                                    words[buffer.ToString()] += 1;
                                    buffer.Clear();
                                }
                            }
                            else
                            {
                                buffer.Append(ch);
                            }
                        }
                    }
                    File.WriteAllLines(path3, (from item in words orderby item.Value descending select string.Format("{0} {1}", item.Key, item.Value)).ToArray());
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
