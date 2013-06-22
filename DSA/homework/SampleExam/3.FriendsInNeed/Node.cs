using System;

namespace _3.FriendsInNeed
{
    class Node : IComparable<Node>
    {
        public int Vertex { get; set; }

        public int Disntace { get; set; }

        public Node(int vertex, int disntace)
        {
            this.Vertex = vertex;
            this.Disntace = disntace;
        }

        public int CompareTo(Node other)
        {
            return this.Disntace.CompareTo(other.Disntace);
        }
    }
}