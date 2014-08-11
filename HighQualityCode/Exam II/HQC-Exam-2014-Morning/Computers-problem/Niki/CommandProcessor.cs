namespace ComputersApplication
{
    using System;

    public static class CommandProcessor
    {
        public static void ProcessCommand(string userInput, Computer pc, Computer server, Computer laptop)
        {
            if (userInput == null)
            {
                throw new ArgumentNullException("User input can't be null!");
            }

            var delimiters = new[]
                {
                    ' '
                };
            var inputCommand = userInput.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            if (inputCommand.Length != 2)
            {
                throw new InvalidArgumentException("Invalid user input, please check number of commands!");
            }

            var command = inputCommand[0];
            var processNumber = int.Parse(inputCommand[1]);

            if (command == "Charge")
            {
                laptop.ChargeBattery(processNumber);
            }
            else if (command == "Process")
            {
                server.Process(processNumber);
            }
            else if (command == "Play")
            {
                pc.Play(processNumber);
            }
            else
            {
                throw new InvalidArgumentException("Invalid command!");
            }
        }
    }
}
