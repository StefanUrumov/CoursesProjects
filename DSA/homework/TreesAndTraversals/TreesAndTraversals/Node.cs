
namespace TreesAndTraversals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Node<T>
    {
        //properties
        public T Value { get; set; }
        public List<Node<T>> Children { get; set; }
        public bool HasParent { get; set; }

        //constructors
        public Node()
        {
            this.Children = new List<Node<T>>();
        }

        public Node(T value)
            : this()
        {
            this.Value = value;
        }
    }
}
