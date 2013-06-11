
namespace TreesAndTraversals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainProgram
    {
        static void Main()
        {
            var N = int.Parse(Console.ReadLine());
            var nodes = new Node<int>[N];

            for (int i = 0; i < N; i++)
            {
                //we use the second constructor
                nodes[i] = new Node<int>(i); //here (i) is <T>
            }

            for (int i = 1; i <= N - 1; i++)
            {
                string edgeAsString = Console.ReadLine();
                var edgeParts = edgeAsString.Split(' ');

                int parentId = int.Parse(edgeParts[0]);
                int childId = int.Parse(edgeParts[1]);

                nodes[parentId].Children.Add(nodes[childId]);
                nodes[childId].HasParent = true;
            }

            // 1a. Find the root
            var root = FindRoot(nodes);
            Console.WriteLine("The root of the tree is: {0}", root.Value);

            // 1b. Find all leafs
            var leafs = FindAllLeafs(nodes);
            Console.Write("Leafs: ");
            foreach (var leaf in leafs)
            {
                Console.Write("{0}, ", leaf.Value);
            }
            Console.WriteLine();

            // 1c. Find all middle nodes
            var middleNodes = FindAllMiddleNodes(nodes);
            Console.Write("Middle nodes: ");
            foreach (var node in middleNodes)
            {
                Console.Write("{0}, ", node.Value);
            }
            Console.WriteLine();

            // 1d. Find the longest path from the root
            var longestPath = FindLongestPath(FindRoot(nodes));
            Console.WriteLine("Number of levels: {0}", longestPath + 1);

            //1e. Find all paths with given sum S of their nodes
            var hasSumOfNodes = FindNodesSumInPaths(nodes);
            Console.WriteLine("There is a path with this sum -> {0}", hasSumOfNodes);

            //1f.Find subtrees with given sum S of their nodes
            var subtreeSumIsTargetSum = FindSubtreeNodesSum(nodes);
            Console.WriteLine("There is a subtree with this sum -> {0}", subtreeSumIsTargetSum);
        }

        private static bool FindSubtreeNodesSum(Node<int>[] nodes)
        {
            Console.WriteLine("Enter target sum for a subtree: ");
            int userSumOfSubtree = int.Parse(Console.ReadLine());

            List<Node<int>> subtree = FindAllMiddleNodes(nodes);
            int currentSubtreeSum = 0;

            foreach (var node in subtree)
            {
                currentSubtreeSum += node.Value;

                foreach (var subnode in node.Children)
                {
                    currentSubtreeSum += subnode.Value;
                }

                if (currentSubtreeSum == userSumOfSubtree)
                {
                    return true;
                }

                currentSubtreeSum = 0;
            }          
            
            return false;
        }

        private static int MyDFS(Node<int>[] nodes, int targetSum)
        {
            Stack<Node<int>> stack = new Stack<Node<int>>();
            var treeRoot = FindRoot(nodes);
            int currentSum = 0;

            //check if the tree is only a root equal to the target sum
            if (treeRoot.Value == targetSum && treeRoot.Children.Count == 0)
            {
                //as true
                return 1;
            }

            stack.Push(treeRoot);
            currentSum += treeRoot.Value;

            while (stack.Count > 0)
            {
                Node<int> currentNode = stack.Pop();
                //Console.Write("{0} ", currentNode.Value);
                
                for (int i = 0; i < currentNode.Children.Count; i++)
                {
                    Node<int> childNode = currentNode.Children[i];                    
                    stack.Push(childNode);
                    currentSum += childNode.Value;
                    currentSum += currentNode.Value;
                    if (currentSum == targetSum)
                    {
                        //equal to true
                        return currentSum;
                    }

                    currentSum -= currentNode.Value;
                    currentSum -= childNode.Value;
                }
            }

            return 0;
        }

        private static bool FindNodesSumInPaths(Node<int>[] nodes)
        {
            Console.WriteLine("Please enter the target sum: ");
            int userInputSum = int.Parse(Console.ReadLine());           
            
            var resultFromDFS = MyDFS(nodes, userInputSum);
            if (resultFromDFS != 0)
            {
                return true;
            }
            
            return false;
            
        }

        static Node<int> FindRoot(Node<int>[] nodes)
        {
            var hasParent = new bool[nodes.Length];

            foreach (var node in nodes)
            {
                foreach (var child in node.Children)
                {
                    hasParent[child.Value] = true;
                }
            }

            for (int i = 0; i < hasParent.Length; i++)
            {
                if (!hasParent[i])
                {
                    return nodes[i];
                }
            }

            throw new ArgumentException("nodes", "The tree has no root.");
        }

        private static int FindLongestPath(Node<int> root)
        {
            if (root.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in root.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static List<Node<int>> FindAllMiddleNodes(Node<int>[] nodes)
        {
            List<Node<int>> middleNodes = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.HasParent && node.Children.Count > 0)
                {
                    middleNodes.Add(node);
                }
            }

            return middleNodes;
        }

        private static List<Node<int>> FindAllLeafs(Node<int>[] nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();

            foreach (var node in nodes)
            {
                if (node.Children.Count == 0)
                {
                    leafs.Add(node);
                }
            }

            return leafs;
        }
    }
}
