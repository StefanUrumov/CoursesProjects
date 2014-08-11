
namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class EventsManager : IEventsManager
    {
        private readonly MultiDictionary<string, Event> _eventsDictionary = 
            new MultiDictionary<string, Event>(true);
        private readonly OrderedMultiDictionary<DateTime, Event> _orderedEvents = new OrderedMultiDictionary<DateTime, Event>(true);

        public void AddEvent(Event occasion)
        {
            string eventTitleLowerCase = occasion.Title.ToLowerInvariant();
            this._eventsDictionary.Add(eventTitleLowerCase, occasion);
            this._orderedEvents.Add(occasion.EventDateTime, occasion);
        }

        public int DeleteEventsByTitle(string eventTitle)
        {
            string lowercaseTitle = eventTitle.ToLowerInvariant();
            var tobeDeleted = this._eventsDictionary[lowercaseTitle];
            int count = tobeDeleted.Count;

            foreach (var element in tobeDeleted)
            {
                this._orderedEvents.Remove(element.EventDateTime, element);
            }

            this._eventsDictionary.Remove(lowercaseTitle);

            return count;
        }

        public IEnumerable<Event> ListEvents(DateTime dateTime, int count)
        {
            var allEvents =
                from events in this._orderedEvents.RangeFrom(dateTime, true).Values
                select events;
            var eventsFinal = allEvents.Take(count);
            return eventsFinal;
        }
    }

}
