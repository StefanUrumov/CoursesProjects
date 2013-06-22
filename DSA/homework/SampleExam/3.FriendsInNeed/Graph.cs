using System.Collections.Generic;

namespace _3.FriendsInNeed
{
    class Graph
    {
        List<Node>[] vertices;
        HashSet<int> hospitals;
        private PriorityQueue<Node> queue;
        private HashSet<int> used;
        int[] distances;

        public Graph(int n)
        {
            vertices = new List<Node>[n];
            hospitals = new HashSet<int>();
        }

        public void AddEdge(int from, int to, int distance)
        {
            this.AddDirectedEdge(from - 1, to - 1, distance);
            this.AddDirectedEdge(to - 1, from - 1, distance);
        }

        private void AddDirectedEdge(int from, int to, int distance)
        {
            if (this.vertices[from] == null)
            {
                this.vertices[from] = new List<Node>();
            }

            var newNode = new Node(to, distance);
            this.vertices[from].Add(newNode);
        }

        public void AddHospital(int hospital)
        {
            this.hospitals.Add(hospital - 1);
        }

        public int GetBestHospital()
        {
            int bestDistance = int.MaxValue;

            foreach (int hospital in hospitals)
            {
                int[] distances = Dijkstra(hospital);
                int distance = Sum(distances);
                if (distance < bestDistance)
                {
                    bestDistance = distance;
                }
            }

            return bestDistance;
        }

        private int Sum(int[] distances)
        {
            int sum = 0;
            for (int vertex = 0; vertex < distances.Length; vertex++)
            {
                if (!hospitals.Contains(vertex))
                {
                    sum += distances[vertex];
                }
            }
            return sum;
        }

        private int[] Dijkstra(int hospital)
        {
            InitializeQueue();
            InitializeUsed();
            InitializeDistances(hospital);
            used.Add(hospital);
            Node startNode = new Node(hospital, 0);

            queue.Enqueue(startNode);
            Node best;
            while (queue.Count > 0)
            {
                best = queue.Dequeue();
                used.Add(best.Vertex);
                foreach (var nextNode in vertices[best.Vertex])
                {
                    int newDistance = distances[best.Vertex] + nextNode.Disntace;
                    if (distances[nextNode.Vertex] > newDistance)
                    {
                        distances[nextNode.Vertex] = newDistance;
                        Node next = new Node(nextNode.Vertex, newDistance);
                        queue.Enqueue(next);
                    }
                }
                ClearUsedVerticesFromQueue();
            }

            return distances;
        }

        private void InitializeDistances(int hospital)
        {
            if (distances == null)
            {
                distances = new int[vertices.Length];
            }
            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = int.MaxValue;
            }
            distances[hospital] = 0;
        }

        private void ClearUsedVerticesFromQueue()
        {
            while (queue.Count > 0 && used.Contains(queue.Peek().Vertex))
            {
                queue.Dequeue();
            }
        }

        private void InitializeUsed()
        {
            if (used == null)
            {
                used = new HashSet<int>();
            }
            else
            {
                used.Clear();
            }
        }

        private void InitializeQueue()
        {
            if (queue == null)
            {
                queue = new PriorityQueue<Node>();
            }
            else
            {
                queue.Clear();
            }
        }
    }
}