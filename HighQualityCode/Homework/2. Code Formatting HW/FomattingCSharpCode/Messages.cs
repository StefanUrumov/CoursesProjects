using System;
using System.Linq;
using System.Text;

namespace FomattingCSharpCode
{
    static class Messages
    {
        public static StringBuilder Output
        {
            get
            {
                return Output;
            }
        }

        public static void EventAdded()
        {
            Output.Append("Event added");
            Output.Append(System.Environment.NewLine);
        }

        public static void EventDeleted(int amount)
        {
            if (amount == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendFormat("{0} events deleted.", amount);
                Output.Append(System.Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            Output.Append("No events found");
            Output.Append(System.Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.Append(eventToPrint);
                Output.Append(System.Environment.NewLine);
            }
        }
    }
}
