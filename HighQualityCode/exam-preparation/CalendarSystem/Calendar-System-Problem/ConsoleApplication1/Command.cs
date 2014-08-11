
namespace CalendarSystem
{
    using System;

    public class Command
    {
        private string _commandName;
        private string[] _arguments;

        public string CommandName
        {
            get
            {
                return _commandName;
            }

            set
            {
                this._commandName = value;
            }
        }

        public string[] Arguments
        {
            get
            {
                return _arguments;
            }

            set
            {
                this._arguments = value;
            }
        }

        private Command(string name, string[] arguments)
        {
            _commandName = name;
            _arguments = arguments;
        }

        public static Command Parse(string inputCommand)
        {
            int sepatator = inputCommand.IndexOf(' ');

            if (sepatator == -1)
            {
                throw new IndexOutOfRangeException("Invalid command order: " + inputCommand);
            }

            string name = inputCommand.Substring(0, sepatator);
            string parameters = inputCommand.Substring(sepatator + 1);

            var commandArguments = parameters.Split('|');

            for (int i = 0; i < commandArguments.Length; i++)
            {
                parameters = commandArguments[i];
                commandArguments[i] = parameters.Trim();
            }

            var command = new Command(name, commandArguments);
            //var command = new Command {CommandName = name, Arguments = commandArguments};

            return command;
        }
   
    }
}
