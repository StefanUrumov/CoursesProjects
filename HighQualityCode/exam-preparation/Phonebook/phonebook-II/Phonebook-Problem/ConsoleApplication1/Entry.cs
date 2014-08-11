
namespace PhonebookApplication
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Entry : IComparable<Entry>
    {
        public SortedSet<string> entyPhones;
        private string name;
        private string nameLowerInvariant;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                nameLowerInvariant = value.ToLowerInvariant();
            }
        }

        public int CompareTo(Entry other)
        {
            return nameLowerInvariant.CompareTo(other.nameLowerInvariant);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Clear();
            result.Append('[');
            result.Append(Name);
            //bool flag = true;

            foreach (string phone in entyPhones)
            {
                result.Append(": ");
                result.Append(", ");
                result.Append(phone);
            }

            result.Append(']');
            return result.ToString();
        }
    }

}
