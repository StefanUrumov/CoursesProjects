
namespace PhonebookApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Repository : IPhonebookRepository
    {
        private readonly Dictionary<string, Entry> _entriesDictionary;
        private readonly MultiDictionary<string, Entry> _entriesMultiDictionary;
        private readonly OrderedSet<Entry> _entriesSorOrderedSet;

        public Repository()
        {
            this._entriesDictionary = new Dictionary<string, Entry>();
            this._entriesMultiDictionary = new MultiDictionary<string, Entry>(false);
            this._entriesSorOrderedSet = new OrderedSet<Entry>();
        }

        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            name = name.ToLowerInvariant();
            Entry entry;
            bool notExisting = !_entriesDictionary.TryGetValue(name, out entry);

            if (notExisting)
            {
                entry = new Entry();
                entry.Name = name;
                entry.entyPhones = new SortedSet<string>();
                _entriesDictionary.Add(name, entry);
                _entriesSorOrderedSet.Add(entry);
            }

            foreach (string number in phoneNumbers)
            {
                _entriesMultiDictionary.Add(number, entry);
            }

            entry.entyPhones.UnionWith(phoneNumbers);
            return notExisting;
        }

        public int ChangePhone(string oldPhoneNumber, string newPhoneNumber)
        {
            List<Entry> found = _entriesMultiDictionary[oldPhoneNumber].ToList(); //todo: maybe bug

            foreach (Entry entry in found)
            {
                entry.entyPhones.Remove(oldPhoneNumber);
                _entriesMultiDictionary.Remove(oldPhoneNumber, entry);


                entry.entyPhones.Add(newPhoneNumber);
                _entriesMultiDictionary.Add(newPhoneNumber, entry);
            }

            return found.Count;
        }

        public Entry[] ListEntries(int first, int num)
        {
            if (first < 0 || first + num > _entriesDictionary.Count)
            {
                //no exception message is thorwn here, the exception is passed for processing 
                throw new IndexOutOfRangeException();
            }

            var list = new Entry[num];

            for (int i = first; i <= first + num - 1; i++)
            {
                Entry entry = _entriesSorOrderedSet[i];
                list[i - first] = entry;
            }

            return list;
        }
    }

}
