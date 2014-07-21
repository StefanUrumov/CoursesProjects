
namespace KpkPracticalExam
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CatalogFreeContent
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();

            foreach (ICommand command in Parse())
            {
                commandExecutor.ExecuteCommand(catalog, command, output); 
            }

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write(output); 
        }

        private static List<ICommand> Parse()
        {
            List<ICommand> instructions = new List<ICommand>();
            bool end = false;

            do
            {
                string inputCommand = Console.ReadLine();
                end = (inputCommand.Trim() == "End");
                
                if (!end)
                {
                    instructions.Add(new Command(inputCommand));
                }
            }
            while (!end);

            return instructions;
        }
    }
}
