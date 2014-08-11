using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace FreeContentCatalogApplication
{
    public class FreeContentCatalog
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();

            foreach (ICommand item in ParseCommands())
            {
                commandExecutor.ExecuteCommand(catalog, item, output);
            }
            
            
            
            //redirect console
            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("C:/Users/User/Desktop/Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);
            Console.WriteLine(output);
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            
            
            
            Console.Write(output); 
        }

        private static List<ICommand> ParseCommands()
        {
            List<ICommand> instructions = new List<ICommand>();
            bool end = false;

            do
            {
                string userInput = Console.ReadLine();
                end = (userInput.Trim() == "End");
                if (!end)
                {
                    instructions.Add(new Command(userInput));
                }

            }
            while (!end);

            return instructions;
        }
    }

    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog catalogContent, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                        catalogContent.Add(new Content(ContentItem.Book, command.Parameters));
                        output.AppendLine("Books Added");
                    break;
                case CommandType.AddMovie:
                        catalogContent.Add(new Content(ContentItem.Movie, command.Parameters));
                        output.AppendLine("Movie added");
                    break;
                case CommandType.AddSong:
                        catalogContent.Add(new Content(ContentItem.Song, command.Parameters));
                        output.Append("Song added");
                    break;
                case CommandType.AddApplication:
                        catalogContent.Add(new Content(ContentItem.Application, command.Parameters));
                        output.AppendLine("Application added");
                    break;
                case CommandType.Update:
                        if (command.Parameters.Length == 2)
                        {
                        output.AppendLine(String.Format("{0} items updated", 
                            catalogContent.UpdateContent(command.Parameters[0], command.Parameters[1]) - 1));
                        }
                        else
                        {
                            throw new FormatException("Incorrect parameters for this command!");
                        }
                    break;
                case CommandType.Find:
                        if (command.Parameters.Length != 2)
                        {
                            throw new ArgumentException("Invalid number of parameters!");
                        }

                        int numberOfElementsToList = int.Parse(command.Parameters[1]);
                        IEnumerable<IContent> foundContent = catalogContent.GetListContent(command.Parameters[0], numberOfElementsToList);

                        if (foundContent.Count() == 0)
                        {
                            output.AppendLine("No items found");
                        }
                        else
                        {
                            foreach (IContent content in foundContent)
                            {
                                output.AppendLine(content.TextRepresentation);
                            }
                        }
                    break;
                default:
                    {
                        throw new ArgumentException("Unknown command!");
                    }
            }
        }
    }

    class Catalog : ICatalog
    {
        private OrderedMultiDictionary<string, IContent> titles;
        private MultiDictionary<string, IContent> url;

        public Catalog()
        {
            //allowDuplicateValues 
            this.titles = new OrderedMultiDictionary<string, IContent>(true);
            this.url = new MultiDictionary<string, IContent>(true);
        }

        public void Add(IContent content)
        {
            this.titles.Add(content.Title, content);
            this.url.Add(content.URL, content);
        }

        public IEnumerable<IContent> GetListContent(string title, int numberOfContentElements)
        {
            var contentToList = from c in this.titles[title] select c;
            return contentToList.Take(numberOfContentElements);
        }

        public int UpdateContent(string oldUrl, string newUrl)
        {
            int theElements = 0; //todo: test and refactor!!!!

            List<IContent> contentToList = this.url[oldUrl].ToList();

            foreach (Content content in contentToList)
            {
                this.titles.Remove(content.Title, content);
                theElements++; //increase updatedElements
            }
            this.url.Remove(oldUrl);


            foreach (IContent content in contentToList)
            {
                content.URL = newUrl;
            }

            //again
            foreach (IContent content in contentToList)
            {
                this.titles.Add(content.Title, content);
                this.url.Add(content.URL, content);
            }

            return theElements;
        }
    }
    
    public class Content : IComparable, IContent
    {
        private string url;
        
        public string Title { get; set; }

        public string Author { get; set; }

        public Int64 Size { get; set; }

        public string URL
        {
            get
            {
                return this.url;
            }
            set
            {
                this.url = value;
            }
        }

        public ContentItem Type { get; set; }

        public string TextRepresentation
        {
            get { return this.ToString(); }
            set { this.TextRepresentation = ToString(); }
        }

        public Content(ContentItem type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)ContentAttributes.Title]; //todo: !?
            this.Author = commandParams[(int)ContentAttributes.Author];
            this.Size = int.Parse(commandParams[(int)ContentAttributes.Size]);
            this.URL = commandParams[(int)ContentAttributes.Url];
        }

        public int CompareTo(object otherObj)
        {
            if (otherObj == null)
            {
                throw new ArgumentNullException("Object to be compared with can't be null!");
            }

            Content otherContent = otherObj as Content;
            
            if (otherContent != null)
            {
                int comparisonResult = this.TextRepresentation.CompareTo(otherContent.ToString());

                return comparisonResult;
            }
            
            throw new ArgumentException("Object is not a Content");
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}", this.Type.ToString(), this.Title, this.Author, this.Size, this.URL);

            return output;
        }
    }
    
    public class Command : ICommand
    {
        readonly char[] paramsSeparators = { ';' };
        readonly char commandEnd = ':';

        public CommandType Type { get; set; }

        public string OriginalForm { get; set; }

        public string Name { get; set; }

        public string[] Parameters { get; set; }

        private Int32 commandNameEndIndex;

        public Command(string input)
        {
            this.OriginalForm = input.Trim();
            this.Parse();
        }

        private void Parse()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();
            this.Name = this.ParseName();
            this.Parameters = this.ParseParameters();
            this.TrimParams();
            this.Type = this.ParseCommandType(this.Name);
        }

        public CommandType ParseCommandType(string commandName)
        {
            CommandType type;

            if (commandName.Contains(':') || commandName.Contains(';'))
            {
                throw new FormatException("Not allowed chars in command!");
            }

            switch (commandName.Trim())
            {
                case "Add book":
                    type = CommandType.AddBook;
                    break;
                case "Add movie":
                    type = CommandType.AddMovie;
                    break;
                case "Add song":
                    type = CommandType.AddSong;
                    break;
                case "Add application":
                    type = CommandType.AddApplication;
                    break;
                case "Update":
                    type = CommandType.Update;
                    break;
                case "Find":
                    type = CommandType.Find;
                    break;
                default:
                    {
                        if (!commandName.ToLower().Contains("book")
                            || !commandName.ToLower().Contains("movie") || !commandName.ToLower().Contains("song")
                            || !commandName.ToLower().Contains("application"))
                        {
                            throw new ArgumentException("Not correct content type!");
                        }

                        if (!commandName.ToLower().Contains("find") || !commandName.ToLower().Contains("update"))
                        {
                            throw new ArgumentException("Not correct command type!");
                        }

                        throw new MissingFieldException("Invalid command name!");
                    }
            }

            return type;
        }

        public string ParseName()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex + 1);
            return name;
        }

        public string[] ParseParameters()
        {
            Int32 paramsLength = this.OriginalForm.Length - (this.commandNameEndIndex + 3);
            string paramsOriginalForm = this.OriginalForm.Substring(this.commandNameEndIndex + 3, paramsLength);
            string[] parameters = paramsOriginalForm.Split(paramsSeparators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i];
            }

            return parameters;
        }

        public Int32 GetCommandNameEndIndex()
        {
            Int32 endIndex = this.OriginalForm.IndexOf(commandEnd) - 1;
            return endIndex;
        }

        private void TrimParams()
        {
            for (int i = 0; i < this.Parameters.Length; i++)
            {
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }

        public override string ToString()
        {
            string toString = String.Empty;

            foreach (string param in this.Parameters)
            {
                toString = this.Name + " " + param;
            }
            
            return toString;
        }
    }
}
