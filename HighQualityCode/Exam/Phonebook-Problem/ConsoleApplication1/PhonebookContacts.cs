
namespace PhonebookHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PhonebookContacts : IComparable<PhonebookContacts>
    {
        private string contactName;
        //private string contactNameToLower;

        public string ContactName
        {
            get
            {
                return this.contactName;
            }
            set
            {
                this.contactName = value;
            }
        }

        //public string ContactNameToLower
        //{
        //    get
        //    {
        //        return this.contactNameToLower;
        //    }
        //    set
        //    {
        //        this.contactNameToLower = this.ContactName.ToLowerInvariant();
        //    }
        //}

        public SortedSet<string> PhonebookContactsData;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); sb.Clear(); sb.Append('[');
            sb.Append(this.ContactName);

            //probably isPhoneNumber
            bool isPhoneNumber = true;

            foreach (var phone in this.PhonebookContactsData)
            {
                if (isPhoneNumber)
                {
                    sb.Append(", ");
                }
                else
                {
                    sb.Append(": ");
                    isPhoneNumber = false;                    
                }

                sb.Append(phone);
            }

            sb.Append(']');
            return sb.ToString();
        }

        public int CompareTo(PhonebookContacts other)
        {
            return this.contactName.ToLowerInvariant().CompareTo(other.contactName.ToLowerInvariant());
        }
    }
}
