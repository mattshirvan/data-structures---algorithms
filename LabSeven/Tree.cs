using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSeven
{
    class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; set; }

        public Node<T> Previous { get; set; }

        public int Count { get; private set; }

        public int MaxCount  { get; set; }

        public bool isEmpty()
        {
            return this.Root == null;
        }

        public void Insert(T newValue)
        {
            Count++;

            //create a new node
            Node<T> newNode = new Node<T>(newValue);

            if (Root == null)//we are adding the first node
            {
                Root = newNode;
            }
            else //we are adding a new node in a non empty tree
            {
                Node<T> finger = Root;
                while (finger != null)
                {
                    if (newValue.CompareTo(finger.Value) <= 0)//move left
                    {
                        //is there a left?
                        if (finger.Left != null)
                            finger = finger.Left;
                        else //there is no  left
                        {
                            //link in the new node
                            finger.Left = newNode;
                            break;
                        }
                    }
                    else //move right
                    {
                        //is there a right?
                        if (finger.Right != null)
                            finger = finger.Right;
                        else
                        {
                            //link in the new node
                            finger.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public Tree<T> add(T value, Node<T> node)
        {
            // start at Root
            // if Root is not null
            if (this.isEmpty())
            {
                this.Root = new Node<T>(value);
                Count++;
                return this;
            }
            // which direction should we go? (if value > Root.value) go right
            if (value.CompareTo(node.Value) > 0)
            {
                // we are looking right!
                // check if right is empty
                if (node.Right == null)
                {
                    // if empty... add node there!
                    node.Right = new Node<T>(value);
                    Count++;
                    return this;
                }
                return this.add(value, node.Right);
            }
            else
            {
                // we are looking left!
                // check if left is empty
                if (node.Left == null)
                {
                    // if empty... add node there!
                    node.Left = new Node<T>(value);
                    Count++;
                    return this;
                }
                return this.add(value, node.Left);
            }
            // if not empty... DESCEND
        }

        // O(n) To search if tree is made of one value
        // i.e. linked list with same values. 5 -> 5 -> 5 -> 5 -> null 
        public int SearchValueCount(T someValue)
        {
            Node<T> finger = Root;
            int count = 0;

            while (finger != null)
            {
                if (someValue.CompareTo(finger.Value) == 0)
                {
                    count++; //found it!!! Then Count it!!!
                    finger = finger.Left;//move left because it has to be less than or equal to
                }
                else if (someValue.CompareTo(finger.Value) > 0)
                    finger = finger.Right;//move right
                else
                    finger = finger.Left;//move left
            }
            return count; //SomeValue not found
        }

        public bool contains(T value, Node<T> node)
        {
            // return true|false if tree contains 'value'
            if (node == null)
            {
                return false;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return true;
            }
            // go searching in one direction
            if (value.CompareTo(node.Value) > 0)
            {
                // go right!
                return this.contains(value, node.Right);
            }
            else
            {
                // go left!
                return this.contains(value, node.Left);
            }
        }
        
        public int size(Node<T> node)
        {
            if (node == null) 
            { 
                return 0; 
            }
 
            return 1 + this.size(node.Left) + this.size(node.Right);
        }

        public void displayValues(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            this.displayValues(node.Right);
            Console.WriteLine(node.Value);
            this.displayValues(node.Left);
        }
        public Node<T> min()
        {
            if (this.isEmpty())
            {
                throw new Exception("Can't search an empty tree");
            }

            // current node
            var current = this.Root;

            // Iteratively find min
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public Node<T> max()
        {
            if (this.isEmpty())
            {
                throw new Exception("Can't search an empty tree");
            }

            // Current node
            var current = this.Root;

            // Iteratively find max
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current;
        }

        public T min(Node<T> node)
        {
            if (this.isEmpty())
            {
                throw new Exception("Can't search an empty tree");
            }

            // Start from node that is passed
            var current = node;

            // Iteratively find min
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current.Value;
        }

        public T max(Node<T> node)
        {
            if (this.isEmpty())
            {
                throw new Exception("Can't search an empty tree");
            }

            // Start from node that is passed
            var current = node;

            // Iteratively find max
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }

        public void PreOrderTraversal(Node<T> node)
        {
            PreOrderTraversalUtil(node);
        }

        public void PostOrderTraversal(Node<T> node)
        {
            PostOrderTraversalUtil(node);
        }

        public void InOrderTraversal(Node<T> node)
        {
            InOrderTraversalUtil(node);
        }

        public void PreOrderTraversalUtil(Node<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrderTraversalUtil(node.Left);
                PreOrderTraversalUtil(node.Right);
            }
        }

        public void PostOrderTraversalUtil(Node<T> node)
        {
            if (node != null)
            {
                PostOrderTraversalUtil(node.Left);
                PostOrderTraversalUtil(node.Right);
                Console.WriteLine(node.Value);
            }
        }

        public void InOrderTraversalUtil(Node<T> node)
        {
            if (node != null)
            {
                InOrderTraversalUtil(node.Left);
                Console.WriteLine(node.Value);
                InOrderTraversalUtil(node.Right);
            }
        }

        public int CountLeafNodes()
        {
            return CountLeafNodesHelper(Root);
        }

        public int CountLeafNodesHelper(Node<T> currentNode)
        {
            if (currentNode == null)
                return 0;
            else if (currentNode.Left == null && currentNode.Right == null)
                return 1;
            else
                return CountLeafNodesHelper(currentNode.Left) + CountLeafNodesHelper(currentNode.Right);
        }

        public int CountNonLeafNodes()
        {
            return CountNonLeafNodesHelper(Root);
        }

        // O(n)
        public int CountNonLeafNodesHelper(Node<T> currentNode)
        {
            if (currentNode == null || (currentNode.Left == null && currentNode.Right == null))
                return 0;
            
            return 1 + CountNonLeafNodesHelper(currentNode.Left) + CountNonLeafNodesHelper(currentNode.Right);
        }


        public bool Valid(Node<T> node)
        {
            return ValidUtil(node, default(T), default(T));
        }

        // O(n) visit every node in tree of size n
        public bool ValidUtil(Node<T> node, T min, T max)
        {
            if (node == null)
            {
                return true;
            }

            if ((min != null && node.Value.CompareTo(min) <= 0) && (max != null && node.Value.CompareTo(max) > 0)) 
            {
                return false;
            }

            return this.ValidUtil(node.Left, min, node.Value) && this.ValidUtil(node.Right, node.Value, max);
        }

        public int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        // Recursive Height counter
        public int Height(Node<T> node)
        {
            if (node == null)
            {
                return -1;
            }

            return 1 + Max(Height(node.Left), Height(node.Right));
        }

        // O(n log n) for Balance calls and Calling height twice for each balance call 
        public bool Balanced(Node<T> node)
        {
            if (node != null)
            {
                // Fails height difference of no more than one
                if (Math.Abs(Height(node.Left) - Height(node.Right)) > 1)
                {
                    return false;
                }

                return Balanced(node.Left) && Balanced(node.Right);
            }

            return true;
        }


        // O(n) to find nth largest in a BST
        public void NthLargest(Node<T> node, int n)
        {

            if (node == null || MaxCount >= n)
            {
                
                return;
            }

            // Inorder traversal
            NthLargest(node.Right, n);


            if (++MaxCount == n)
            {
                // Value found
                Console.WriteLine(node.Value);
                return;
            }

            NthLargest(node.Left, n);
        }

        public void kThLargest(int K)
        {
            int count = 1;
            kThLargestHelper(Root, ref count, K);
        }

        public void kThLargestHelper(Node<T> currentNode, ref int currentCount, int K)
        {
            if (currentNode != null)
            {
                kThLargestHelper(currentNode.Right, ref currentCount, K);//R

                if (K == currentCount) //I found it!
                {
                    Console.WriteLine(currentNode.Value);//N

                }
                currentCount++;

                kThLargestHelper(currentNode.Left, ref currentCount, K);//L
            }
        }

        // Problem 1 - List of Depths O(n) BFS instead of recursive
        public List<LinkedList<Node<T>>> ListofDepths(Node<T> root)
        {
            // List of depths 
            List<LinkedList<Node<T>>> list = new List<LinkedList<Node<T>>>();

            // Linked List of nodes (depth/level)
            LinkedList<Node<T>> level = new LinkedList<Node<T>>();

            // Check if the tree exists
            if (root != null)
            {
                level.AddLast(root);    
            }

            // Check each node in the level
            while (level.Count > 0)
            {
                // Add to the list of depths
                list.Add(level);

                // Previous level (list of nodes)
                LinkedList<Node<T>> nodes = level ;

                // New Level
                level = new LinkedList<Node<T>>();

                // Traverse the previous level
                foreach (Node<T> node in nodes)
                {
                    if (node.Left != null)
                    {
                        level.AddLast(node.Left);
                    }

                    if (node.Right != null)
                    {
                        level.AddLast(node.Right);
                    }
                }
            }

            return list;
        }

        // Problem 2 - Minumum Height O(log n)
        public Node<T> MinHeight(T[] values)
        {
            return MinHeightUtil(values, 0, values.Length - 1);
        }

        public Node<T> MinHeightUtil(T[] values, int start, int stop)
        {
            if (start <= stop)
            {
                // Split array in half
                int mid = (start + stop) / 2;

                // Create a new node in the tree
                Node<T> node = new Node<T>(values[mid]);

                // Insert left
                node.Left = MinHeightUtil(values, start, mid - 1);

                // Insert Right
                node.Right = MinHeightUtil(values, mid + 1, stop);

                return node;
            }
            return null;
        }

        // Problem 3 - Path between nodes O(n) to search i.e. (src) root = 0 (dst) dstnode = 1 path of 1 billion 2's (0->2->2->2-> ... -> 1)
        public void PrintAllPaths(Node<T> source, Node<T> destination)
        {
            Console.WriteLine("Printing path between nodes ...");
            if (source != null && destination != null)
                PrintAllPathsHelper(source, destination, "");
            else
                Console.WriteLine("The tree is empty, no paths found between src -> dst");
            Console.WriteLine("=========================");
        }

        public void PrintAllPathsHelper(Node<T> currentNode, Node<T> destinationNode, string PathSoFar)
        {
            if (currentNode.Left != null && currentNode.Value.CompareTo(destinationNode.Value) > 0)
                PrintAllPathsHelper(currentNode.Left, destinationNode, PathSoFar + "-> " + currentNode.Value);
            if (currentNode.Right != null && currentNode.Value.CompareTo(destinationNode.Value) < 0)
                PrintAllPathsHelper(currentNode.Right, destinationNode, PathSoFar + "-> " + currentNode.Value);
            if (currentNode.Value.CompareTo(destinationNode.Value) == 0)
                Console.WriteLine(PathSoFar + "-> " + currentNode.Value);//end of the path - the leaf
        }

        public Tree()
        {

        }

        public Tree(Node<T> node)
        {
            Root = node;
        }
    }
}
