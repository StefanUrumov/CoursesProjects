using System;
using System.Linq;
using System.Text;

namespace FomattingCSharpCode
{
    class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }


        public Event(DateTime date, String title, String location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object otherObject)
        {
            Event otherEvent = otherObject as Event;

            if (this == null)
            {
                if (otherEvent == null)
                {
                    return 0; 
                }
                else
                {
                    return -1;
                }
            }
            else if (otherEvent == null)
            {
                return 1;
            }                
            else
            {
                int byDate = this.Date.CompareTo(otherEvent.Date);
                int byTitle = this.Title.CompareTo(otherEvent.Title);
                int byLocation = this.Location.CompareTo(otherEvent.Location);

                if (byDate == 0)
                {
                    if (byTitle == 0)
                    {
                        return byLocation;
                    }
                    else
                    {
                        return byTitle;
                    }
                }
                else
                {
                    return byDate;
                }
            }            
        }
        

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();
            finalResult.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));

            finalResult.Append(" | " + title);

            if (location != null && location != "")
            {
                finalResult.Append(" | " + location);
            }

            return finalResult.ToString();
        }
    }
}