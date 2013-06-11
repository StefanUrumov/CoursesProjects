
namespace _05.HashSet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _04.HashTable;

    public class HashSet<T> : IEnumerable<T>
    {
        private HashTable<T, bool> set;

        public HashSet(int capacity = 16)
        {
            this.set = new HashTable<T, bool>(capacity);
        }

        public int Count
        {
            get
            {
                return this.set.Count;
            }
        }

        //public int Capacity
        //{
        //    get
        //    {
        //        return this.set.Capacity;
        //    }
        //}

        public void Add(T value)
        {
            set.Add(value, true);
        }

        public void Remove(T value)
        {
            set.Remove(value);
        }

        public void Clear()
        {
            this.set.Clear();
        }

        //public T Find(T value)
        //{
        //    return set.FindPair(value).Key;
        //}

        //public bool Contains(T key)
        //{
        //    return this.set.Contains(key);
        //}

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.set)
            {
                yield return item.Key;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Union(HashSet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                if (!this.Contains(item))
                {
                    this.Add(item);
                }
            }
        }

        public void Intersect(HashSet<T> otherSet)
        {
            var newSet = new HashTable<T, bool>(); //(this.Capacity)
            foreach (var item in this)
            {
                if (otherSet.Contains(item))
                {
                    newSet.Add(item, true);
                }
            }

            this.set = newSet;
        }
    }
}

