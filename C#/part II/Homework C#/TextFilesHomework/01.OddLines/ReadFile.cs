﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.OddLines
{
    class ReadFile
    {
        static void Main()
        {
            Console.WriteLine("Enter the full path of the text file (example: C:\\some dir\\SomeTextFile.TXT");
            string filePath = Console.ReadLine();

            //pass the file path via string
            StreamReader sr = new StreamReader(@filePath);

            Console.WriteLine("The odd lines are: ");
            //Read the first line of text

            int lineCount = 1;
            string line = sr.ReadLine();     
            
            try
            {   
                //Continue to read odd lines
                while (line != null)
                {

                    if (lineCount % 2 != 0)
                    {
                        //write the line to console window
                        Console.WriteLine(line);
                    }
                    lineCount++;
                    //Read the next line
                    line = sr.ReadLine();
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
            finally
            {
                //close the file
                sr.Close();
            }

            Console.WriteLine("End of file reached!");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }
    }
}