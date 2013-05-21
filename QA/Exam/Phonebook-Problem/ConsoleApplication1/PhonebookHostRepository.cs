
namespace PhonebookHost
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class PhonebookHostRepository : IPhonebookRepository
    {
        private OrderedSet<PhonebookContacts> sortedPhonebook = new OrderedSet<PhonebookContacts>();
        private Dictionary<string, PhonebookContacts> contactsDictionary = new Dictionary<string, PhonebookContacts>();
        private MultiDictionary<string, PhonebookContacts> contactsMultiDictionary = new MultiDictionary<string, PhonebookContacts>(false);

        public bool AddPhone(string contactName, IEnumerable<string> phoneNumbers)
        {
            string contactNameToLower = contactName.ToLowerInvariant();
            PhonebookContacts phonebookContactEntries;
            bool contactPhoneIsAdded = !this.contactsDictionary.TryGetValue(contactNameToLower, out phonebookContactEntries);

            if (contactPhoneIsAdded)
            {
                phonebookContactEntries = new PhonebookContacts();
                phonebookContactEntries.ContactName = contactName;
                phonebookContactEntries.PhonebookContactsData = new SortedSet<string>();
                this.contactsDictionary.Add(contactNameToLower, phonebookContactEntries);
                this.sortedPhonebook.Add(phonebookContactEntries);
            }
            //probably else - return exception
            foreach (var number in phoneNumbers)
            {
                this.contactsMultiDictionary.Add(number, phonebookContactEntries);
            }

            phonebookContactEntries.PhonebookContactsData.UnionWith(phoneNumbers);
            return contactPhoneIsAdded;
        }

        public int ChangePhone(string oldPhoneNumberEntry, string newPhoneNumberEntry)
        {
            var oldEntriesList = this.contactsMultiDictionary[oldPhoneNumberEntry].ToList();

            foreach (var entry in oldEntriesList)
            {
                entry.PhonebookContactsData.Remove(oldPhoneNumberEntry);
                this.contactsMultiDictionary.Remove(oldPhoneNumberEntry, entry);
                entry.PhonebookContactsData.Add(newPhoneNumberEntry);
                this.contactsMultiDictionary.Add(newPhoneNumberEntry, entry);
            }

            return oldEntriesList.Count;
        }

        public PhonebookContacts[] List(int first, int contactPhoneNumbersCount)
        {
            if (first < 0 || first + contactPhoneNumbersCount > this.contactsDictionary.Count) //10
            {
                throw new ArgumentOutOfRangeException("Invalid contact details! Please check the contact phones count. Must be in range[1..10]");
            }

            PhonebookContacts[] phoneContactsList = new PhonebookContacts[contactPhoneNumbersCount];

            for (int i = first; i <= first + contactPhoneNumbersCount - 1; i++)
            {
                PhonebookContacts phonebookItemsSorted = this.sortedPhonebook[i];
                phoneContactsList[i - first] = phonebookItemsSorted;
            }

            return phoneContactsList;
        }
    }
}
