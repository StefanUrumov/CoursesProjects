
namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PhonebookApplication
    {
        private const string code = "+359";
        private static IPhonebookRepository phonebookData = new PhonebookRepository();
        private static StringBuilder output = new StringBuilder();

        private static void Main()
        {
            while (true)
            {
                string inputData = Console.ReadLine();
                if (inputData == "End" || inputData == null)
                {
                    // Stop reading from console 
                    break;
                }

                PhonebookController(inputData);
            }
        }

        private static void PhonebookController(string inputData)
        {
            int indexBracket = inputData.IndexOf('(');
            
            if (indexBracket == -1)
            {
                throw new ArgumentException("Not correct placed brackets!");
            }

            string command = inputData.Substring(0, indexBracket);
            
            if (!inputData.EndsWith(")"))
            {
                Main(); //todo: must remove!
            }

            string numbersContent = inputData.Substring(indexBracket + 1, inputData.Length - indexBracket - 2);
            string[] numbersFound = numbersContent.Split(',');

            for (int number = 0; number < numbersFound.Length; number++)
            {
                numbersFound[number] = numbersFound[number].Trim();
            }

            if ((command.StartsWith("AddPhone")) && (numbersFound.Length >= 2))
            {
                CommandHandler("AddPhone", numbersFound);
            }
            else if ((command.StartsWith("ChangePhone") && (numbersFound.Length == 2)))
            {
                CommandHandler("ChangePhone", numbersFound);
            }
            else if (command.StartsWith("List") && (numbersFound.Length == 2))
            {
                CommandHandler("List", numbersFound);
            }
            else
            {
                throw new IndexOutOfRangeException("Not supported command!");
            }
        }

        private static void CommandHandler(string command, string[] arguments)
        {
            if (command == "AddPhone")
            {
                string userName = arguments[0];
                var phones = arguments.Skip(1).ToList(); //skip entry name and work with numbers only
                for (int i = 0; i < phones.Count;i++)
                {
                    phones[i] = ExtractNumbers(phones[i]);
                }
                bool isAdded = phonebookData.AddPhone(userName, phones);
                
                if (isAdded)
                {
                    Print("Phone entry created");
                }
                else
                {
                    Print("Phone entry merged");
                }
            }
            else if (command == "ChangePhone")
            {
                Print(phonebookData.ChangePhone(ExtractNumbers(arguments[0]), ExtractNumbers(arguments[1])) + " numbers changed");
            }
            else if (command == "List")
            {
                try
                {
                    IEnumerable<PhonebookEntry> entries = phonebookData.ListEntries(int.Parse(arguments[0]), int.Parse(arguments[1]));
                    foreach (var entry in entries)
                    {
                        try
                        {
                            Print(entry.ToString());
                        }
                        catch (NullReferenceException nre)
                        {
                            //in case for invalid range and not found entry, should be handled
                        }
                    }
                }
                catch (IndexOutOfRangeException iore)
                {
                    Console.WriteLine("Invalid range");
                    //Console.WriteLine(iore.Message);
                    //Console.WriteLine(iore.StackTrace);
                }
            }

            Console.Write(output);
            output.Clear(); //keep only actual and current application responce
        }

        private static string ExtractNumbers(string number)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i <= output.Length; i++)
            {
                foreach (char ch in number)
                {
                    if (char.IsDigit(ch) || (ch == '+'))
                    {
                        result.Append(ch);
                    }
                }

                if (result.Length >= 2 && result[0] == '0' && result[1] == '0')
                {
                    result.Remove(0, 1);
                    result[0] = '+';
                }
                
                while (result.Length > 0 && result[0] == '0')
                {
                    result.Remove(0, 1);
                }
                
                if (result.Length > 0 && result[0] != '+')
                {
                    result.Insert(0, code);
                }
            }
            return result.ToString();
        }

        private static void Print(string text)
        {
            output.AppendLine(text);
        }
    }

    //internal class REPNew : IPhonebookRepository is obsolete and it's removed

}
