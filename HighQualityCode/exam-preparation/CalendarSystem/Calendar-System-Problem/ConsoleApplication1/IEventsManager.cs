
namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;

    public interface IEventsManager
    {
        void AddEvent(Event occasion);
        int DeleteEventsByTitle(string eventName);
        IEnumerable<Event> ListEvents(DateTime time, int count);
   
    }
}
