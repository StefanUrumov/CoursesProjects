using System;
using Wintellect.PowerCollections;

namespace _3.FriendsInNeed
{
    class PriorityQueue<T> where T : IComparable<T>
    {
        private OrderedBag<T> bag;

        public int Count
        {
            get
            {
                return bag.Count;
            }
            private set
            {
            }
        }

        public PriorityQueue()
        {
            bag = new OrderedBag<T>();
        }

        public void Enqueue(T element)
        {
            bag.Add(element);
        }

        public T Dequeue()
        {
            var element = bag.GetFirst();
            bag.RemoveFirst();
            return element;
        }

        public void Clear()
        {
            this.bag.Clear();
        }

        public T Peek()
        {
            var element = bag.GetFirst();
            return element;
        }
    }
}