
namespace PhonebookApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Phonebook
    {
        private const string phoneCode = "+359";

        private static readonly IPhonebookRepository PhonebookRepository = new Repository();

        private static readonly StringBuilder input = new StringBuilder();

        private static void Main()
        {
            while (true)
            {
                string data = Console.ReadLine();

                if (data == "End" || data == null)
                {
                    //Stop reading user input from console 
                    break;
                }

                ProcessUserInput(data);
            }
            //Console.Write(input);
        }

        private static void ProcessUserInput(string data)
        {
            int bracketIndex = data.IndexOf('(');

            if (bracketIndex == -1)
            {
                throw new ArgumentException("Invalid command! Please check syntax.");
            }

            string command = data.Substring(0, bracketIndex);

            if (!data.EndsWith(")"))
            {
                Main(); //todo: refactor
            }

            string arguments = data.Substring(bracketIndex + 1, data.Length - bracketIndex - 2);
            string[] strings = arguments.Split(',');

            for (int j = 0; j < strings.Length; j++)
            {
                strings[j] = strings[j].Trim();
            }

            if ((command == "AddPhone") && (strings.Length >= 2))
            {
                ProcessCommand("AddPhone", strings);
            }
            else if ((command == "ChangePhone") && (strings.Length == 2))
            {
                ProcessCommand("ChangePhone", strings);
            }
            else if ((command == "List") && (strings.Length == 2))
            {
                ProcessCommand("List", strings);
            }
            else
            {
                throw new ArgumentException("Not supported command!");
            }
        }

        private static void ProcessCommand(string command, string[] arguments)
        {
            if (command == "AddPhone")
            {
                string name = arguments[0];
                List<string> phones = arguments.Skip(1).ToList();

                for (int i = 0; i < phones.Count; i++)
                {
                    phones[i] = Convert(phones[i]);
                }

                bool isAdded = PhonebookRepository.AddPhone(name, phones);

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
                Print(PhonebookRepository.ChangePhone(Convert(arguments[0]), Convert(arguments[1])) + " numbers changed");
            }
            else if (command.StartsWith("List"))
            {
               try
               {
                 IEnumerable<Entry> entries = PhonebookRepository.ListEntries(int.Parse(arguments[0]), int.Parse(arguments[1]));
                 foreach (Entry entry in entries)
                 {
                     Print(entry.ToString());
                 }
               }
               catch (IndexOutOfRangeException iore)
               {
                   Print("Invalid range");
               }
            }
        }

        private static string Convert(string numbers)
        {
            var result = new StringBuilder();

            for (int i = 0; i <= input.Length; i++)
            {
                result.Clear();
                //removed duplicated code 
                foreach (char ch in numbers)
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
                    result.Insert(0, phoneCode);
                }
            }

            return result.ToString();
        }

        private static void Print(string text)
        {
            input.AppendLine(text);
        }
    }
    
    //public class REPNew : IPhonebookRepository is not needed

}