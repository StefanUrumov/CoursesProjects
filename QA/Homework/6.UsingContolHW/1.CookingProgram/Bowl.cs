
namespace _1.CookingProgram
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class Bowl : IList
    {
        private readonly IList bowlDish = new List<IVegetable>();

        public void CopyTo(Array array, int arrayIndex)
        {
            bowlDish.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return bowlDish.Count; }            
        }

        public object SyncRoot
        {
            get { return bowlDish.SyncRoot; }
        }

        public bool IsSynchronized
        {
            get { return bowlDish.IsSynchronized; }
        }

        public IEnumerator GetEnumerator()
        {
            return bowlDish.GetEnumerator();
        }

        public int Add(object cookingProduct)
        {
            return bowlDish.Add(cookingProduct);
        }

        public bool Contains(object cookingProduct)
        {
            return bowlDish.Contains(cookingProduct);
        }

        public void Clear()
        {
            bowlDish.Clear();
        }

        public int IndexOf(object cookingProduct)
        {
            return bowlDish.IndexOf(cookingProduct);
        }

        public void Insert(int index, object cookingProduct)
        {
            bowlDish.Insert(index, cookingProduct);
        }

        public void Remove(object cookingProduct)
        {
            bowlDish.Remove(cookingProduct);
        }

        public void RemoveAt(int index)
        {
            bowlDish.RemoveAt(index);
        }

        public object this[int index]
        {
            get
            {
                return bowlDish[index];
            }
            set
            {
                bowlDish[index] = value;
            }
        }

        public bool IsReadOnly
        {
            get { return bowlDish.IsReadOnly; }
        }

        public bool IsFixedSize
        {
            get { return bowlDish.IsFixedSize; }
        }
    }
}
