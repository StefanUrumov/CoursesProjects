
namespace _04.HashTable
{
    using System;
    using System.Linq;

    public class KeyValuePair<K, V>
    {
        public KeyValuePair()
        {
        }

        public KeyValuePair(K key, V value)
        {
            this.Key = key;
            this.Value = value;
        }

        public K Key
        {
            get;
            private set;
        }

        public V Value
        {
            get;
            set;
        }
    }
}
