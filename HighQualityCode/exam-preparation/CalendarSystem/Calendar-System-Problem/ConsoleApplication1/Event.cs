
namespace CalendarSystem
{
    using System;

    public class Event : IComparable<Event>
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime EventDateTime { get; set; }

        public Event(string title, string location, DateTime eventDateTime)
        {
            this.Title = title;
            this.Location = location;
            this.EventDateTime = eventDateTime;
        }

        public override string ToString()
        {
            string format = "{0:yyyy-MM-ddTH:mm:ss} | {1}";

            if (this.Location != null)
            {
                format += " | {2}";
            }

            string eventAsString = string.Format(format, this.EventDateTime, this.Title, this.Location);
            //remove useless chars from output
            if (eventAsString[eventAsString.Length - 1] == '|' || eventAsString[eventAsString.Length - 2] == '|')
            {
                //consider empty spaces between arguments
                eventAsString.Remove(eventAsString.LastIndexOf('|') - 1);
            }
            return eventAsString;
        }

        public int CompareTo(Event other)
        {
            int result = DateTime.Compare(this.EventDateTime, other.EventDateTime);
            foreach (char c in this.Title)
            {
                if (result == 0)
                {
                    result = string.Compare(this.Title, other.Title, StringComparison.Ordinal);
                }

                if (result == 0)
                {
                    result = string.Compare(this.Location, other.Location, StringComparison.Ordinal);
                }
            }

            return result;
        }
    }

}
