
namespace KpkPracticalExam
{
    using System;
    using System.Linq;

    public interface ICommand
    {
        CommandContent Type { get; set; }
        string OriginalForm { get; set; }
        string Name { get; set; }
        string[] Parameters { get; set; }
        CommandContent ParseCommandType(string commandName);
        string ParseName();
        string[] ParseParameters();
    }
}
