
namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhonebookEntry : IComparable<PhonebookEntry>
    {
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public SortedSet<string> PhoneNumbers;

        public override string ToString()
        {
            StringBuilder fullEntry = new StringBuilder();
            fullEntry.Append('[');
            fullEntry.Append(FirstName);
            bool hasPhone = true;
            foreach (var phone in PhoneNumbers)
            {
                if (hasPhone)
                {
                    fullEntry.Append(": ");
                    hasPhone = false;
                }
                else
                {
                    fullEntry.Append(", ");
                }
                fullEntry.Append(phone);
            }
            fullEntry.Append(']');
            return fullEntry.ToString();
        }

        public int CompareTo(PhonebookEntry other)
        {
            return this.FirstName.CompareTo(other.FirstName);
            //return String.Compare(lastName, other.lastName, System.StringComparison.Ordinal);
        }
    }
}
