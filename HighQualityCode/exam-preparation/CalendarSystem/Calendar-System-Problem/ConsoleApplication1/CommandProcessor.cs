

namespace CalendarSystem
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class CommandProcessor
    {
        private readonly IEventsManager eventsManager;

        public CommandProcessor(IEventsManager eventsManager)
        {
            this.eventsManager = eventsManager;
        }

        public IEventsManager EventsProcessor
        {
            get
            {
                return this.eventsManager;
            }
        } 

        public string ProcessCommand(Command inputCommand)
        {
            // AddEvent command
            if ((inputCommand.CommandName == "AddEvent"))
            {
                var date = DateTime.ParseExact(inputCommand.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                Event occasion = null;
                string location = String.Empty;
                string title = inputCommand.Arguments[1];

                if (inputCommand.Arguments.Length == 2)
                {
                    location = "";
                }
                else if (inputCommand.Arguments.Length == 3)
                {
                    location = inputCommand.Arguments[2];
                }

                occasion = new Event(title, location, date);

                this.eventsManager.AddEvent(occasion);

                return "Event added";
            }
            // DeleteEvents command
            if ((inputCommand.CommandName == "DeleteEvents") && (inputCommand.Arguments.Length == 1))
            {
                int count = this.eventsManager.DeleteEventsByTitle(inputCommand.Arguments[0]);

                if (count == 0)
                {
                    return "No events found.";
                }

                return count + " events deleted";
            }
            // ListEvents command
            if ((inputCommand.CommandName == "ListEvents") && (inputCommand.Arguments.Length == 2))
            {
                var date = DateTime.ParseExact(inputCommand.Arguments[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var count = int.Parse(inputCommand.Arguments[1]);
                var events = this.eventsManager.ListEvents(date, count);//.ToList(); not needed 
                var finalResult = new StringBuilder();

                if (!events.Any())
                {
                    return "No events found";
                }

                events = events.OrderBy(e => e.EventDateTime).ThenBy(e => e.Title).ThenBy(e => e.Location);

                foreach (var occasion in events)
                {
                    finalResult.AppendLine(occasion.ToString());
                }

                return finalResult.ToString().Trim();
            }

            throw new IndexOutOfRangeException("This " + inputCommand.CommandName + " is not supported!");
        }
    }

}
