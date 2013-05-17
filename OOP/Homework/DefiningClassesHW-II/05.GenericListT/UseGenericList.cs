using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.GenericListT
{
    public class UseGenericList<T> 
    {        
        const int fixedCapacity = 10;
        private static T[] elements;
        private static int count = 0;

        //Constructors
        public void GenericList (int fixedCapacity)
        {
           elements = new T[fixedCapacity];
        }

        //public GenericList()
        //    :this(fixedCapacity)
        //{
        //}

        //Properties
        public static int Count
        {
            get{return count;}
        }

        //Methods
        public static T Add(T element)
        {
            if (count == elements.Length)
            {
                AutoGrow();
            }
            elements[count] = element;
            count++;
            return element;
        }

        public static void AutoGrow()
        {
            T[] doubleElements = new T[2*elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                doubleElements[i] = elements[i];
            }
            elements = doubleElements;
        }

        public T this[int index]
        {
            get {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                T result = elements[index];
                return result;
            }
        }

        public static void Remove(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            T[] newArray = new T[elements.Length - 1];
            for (int i = 0, k = 0; i < newArray.Length; i++, k++)
            {
                if (i == index)
                {
                    k++;
                }
                newArray[i] = elements[k];
            }
            count--;
            elements = newArray;
        }

        public static void Insert(T element, int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            T[]newArray = new T[elements.Length-1];
            for (int i = 0, k = 0; i < newArray.Length + 1; i++, k++)
            {
                T curr = elements[i];
                if (i == index)
                {
                    k++;
                    newArray[i] = element;
                }
                newArray[k] = curr;
            }
            count++;
            elements = newArray;
        }

        public static void Clear()
        {
            count = 0;
            elements = new T[fixedCapacity];
        }

        public static void FindElement<T>(T element, UseGenericList<T> elements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Equals(element))
                {
                    Console.WriteLine("the element is at index: {0}", i);
                }
                return;
            }
            Console.WriteLine("Not found!");
        }

        //Override
        public override string ToString()
        {
            StringBuilder console = new StringBuilder();
            for (int i = 0; i < elements.Length; i++)
            {
                console.Append(elements[i]);
                console.Append(' ');
            }

            return console.ToString();
        }

        public static T Max<T>()
            where T: IComparable<T>, IComparable
        {
            dynamic max = elements[0];
            for (int i = 0; i < count; i++)
            {
                T tempValue = (dynamic)elements[i];
                if (tempValue.CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        public static T Min<T>()
            where T : IComparable<T>, IComparable
        {
            dynamic min = elements[0];
            for (int i = 0; i < count; i++)
            {
                T tempValue = (dynamic)elements[i];
                if (tempValue.CompareTo(min) > 0)
                {
                    min = elements[i];
                }
            }
            return min;
        }
    }
}
