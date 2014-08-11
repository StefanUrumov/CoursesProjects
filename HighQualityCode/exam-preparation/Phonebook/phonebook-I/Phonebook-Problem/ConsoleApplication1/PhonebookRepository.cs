
using System.Linq;

namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class PhonebookRepository : IPhonebookRepository
    {
        private readonly OrderedSet<PhonebookEntry> _sortedEntries;

        private readonly Dictionary<string, PhonebookEntry> _phonebookDictionary;

        private readonly MultiDictionary<string, PhonebookEntry> _phonebookMultiDictionary;

        //private fields are initialized in constructor
        public PhonebookRepository()
        {
            _sortedEntries = new OrderedSet<PhonebookEntry>();
            _phonebookDictionary = new Dictionary<string, PhonebookEntry>();
            _phonebookMultiDictionary = new MultiDictionary<string, PhonebookEntry>(false);
        }

        public bool AddPhone(string userName, IEnumerable<string> phoneNumbers)
        {
            string userNameLowerInvariant = userName.ToLowerInvariant();
            PhonebookEntry entry;
            bool foundEntry = !_phonebookDictionary.TryGetValue(userNameLowerInvariant, out entry);
            
            if (foundEntry)
            {
                entry = new PhonebookEntry();
                entry.FirstName = userName;
                entry.PhoneNumbers = new SortedSet<string>();
                _phonebookDictionary.Add(userNameLowerInvariant, entry);
                _sortedEntries.Add(entry);
            }

            foreach (var number in phoneNumbers)
            {
                _phonebookMultiDictionary.Add(number, entry);
            }
            entry.PhoneNumbers.UnionWith(phoneNumbers);
            return foundEntry;
        }

        public int ChangePhone(string oldEntry, string newEntry)
        {
            List<PhonebookEntry> found = _phonebookMultiDictionary[oldEntry].ToList();

            for (int entry = 0; entry < found.Count; entry++)
            {
                found[entry].PhoneNumbers.Remove(oldEntry);
                _phonebookMultiDictionary.Remove(oldEntry, found[entry]);
                found[entry].PhoneNumbers.Add(newEntry);
                _phonebookMultiDictionary.Add(newEntry, found[entry]);
            }
            
            return found.Count;
        }

        public PhonebookEntry[] ListEntries(int firstFound, int resultsCount)
        {
            if (firstFound < 0 || firstFound + resultsCount > _phonebookDictionary.Count)
            {
                //todo: must be replaced with exception bellow
                //throw  new IndexOutOfRangeException("Invalid start index or count.");
            }

            PhonebookEntry[] phonebookEntries = new PhonebookEntry[resultsCount];

            try
            {
                for (int i = firstFound; i <= firstFound + resultsCount - 1; i++)
                {
                    PhonebookEntry entry = this._sortedEntries[i];
                    phonebookEntries[i - firstFound] = entry;
                }
            }
            catch (ArgumentOutOfRangeException aore)
            {
                Console.WriteLine("Invalid range"); 
            }
            return phonebookEntries;
        }
    }
}
