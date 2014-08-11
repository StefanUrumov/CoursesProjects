
namespace CalendarSystem
{
    using System;

    public class CalendarSystemApplication
    {
        internal static void Main()
        {
            var eventsManager = new EventsManager();
            var processor = new CommandProcessor(eventsManager);

            while (true)
            {
                string inputCommand = Console.ReadLine();
                if (inputCommand == "End" || inputCommand == null)
                {
                    break;
                }
               
               // Read sequence of commands, untill is finished and display results
               Console.WriteLine(processor.ProcessCommand(Command.Parse(inputCommand)));
            }
        }
    }
   
    //public class EventsManager : IEventsManager
    //{
    //    private readonly List<Event> eventsList = new List<Event>();

    //    public void AddEvent(Event occasion)
    //    {
    //        this.eventsList.Add(occasion);
    //    }

    //    public int DeleteEventsByTitle(string eventTitle)
    //    {
    //        return this.eventsList.RemoveAll(e => e.Title.ToLowerInvariant() == eventTitle.ToLowerInvariant());
    //    }

    //    public IEnumerable<Event> ListEvents(DateTime eventDateTime, int count)
    //    {
    //        return (from e in this.eventsList
    //            where e.EventDateTime >= eventDateTime
    //            orderby e.EventDateTime, e.Title, e.Location
    //            select e).Take(count);
    //    }
    //}
    
    
}





