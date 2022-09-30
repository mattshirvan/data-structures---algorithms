using System;

namespace WEEK06_BST
{
    

    class Node<T>
    {
        //data
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right{ get; set; }
        //methods

        //ctor
        public Node(T someValue)
        {
            Value = someValue;
        }
    }

    class BST<T> where T : IComparable
    {
        //data
        public Node<T> root { get; private set; }
        public int Count { get; private set; }

        //methods
        public void Insert(T newValue)
        {
            Count++;

            //create a new node
            Node<T> newNode = new Node<T>(newValue);

            if(root==null)//we are adding the first node
            {
                root = newNode;
            }
            else //we are adding a new node in a non empty tree
            {
                Node<T> finger = root;
                while(finger!=null)
                {
                    if (newValue.CompareTo(finger.Value) <= 0)//move left
                    {
                        //is there a left?
                        if(finger.Left!=null)
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
                        if(finger.Right!=null)
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

        public Node<T> Search(T someValue)
        {
            Node<T> finger = root;
            while(finger!=null)
            {
                if (someValue.CompareTo(finger.Value) == 0)
                    return finger; //found it!!!
                else if (someValue.CompareTo(finger.Value)>0)
                    finger = finger.Right;//move right
                else
                    finger=finger.Left;//move left
            }
            return null; //SomeValue not found
        }

        public Node<T> Search2(T someValue)
        {
            Node<T> finger = root;
            while (finger != null)
            {
                if (someValue.CompareTo(finger.Value) == 0)
                    break; //found it!!!
                else if (someValue.CompareTo(finger.Value) > 0)
                    finger = finger.Right;//move right
                else
                    finger = finger.Left;//move left
            }
            return finger; //SomeValue not found
        }

        public void Delete(T value)
        {
            throw new NotImplementedException();
        }


        public void Delete(Node<T> nodeToDelete)
        {
            throw new NotImplementedException();
        }

        //traversals...
        //FindDepth
        //

        public T FindMax()
        {
            if (root == null) //tree is empty
                throw new Exception("Empty tress have no max values!");
            else
            {
                Node<T> finger = root;
                //move right as much as possible
                while (finger.Right != null) //if there is a right node
                    finger = finger.Right;

                //stop the loop when there is nothing to the right
                return finger.Value;
            }
        }

        public T FindMin()
        {
            throw new NotImplementedException();
        }

        public void InOrderTraversal()
        {
            InOrderTraversalHelper(root);
            Console.WriteLine();
        }

        public void InOrderTraversalHelper(Node<T> currentNode)
        {
            if(currentNode!=null)
            {
                InOrderTraversalHelper(currentNode.Left);//L
                Console.Write(currentNode.Value+", ");//N
                InOrderTraversalHelper(currentNode.Right);//R
            }
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversalHelper(root);
            Console.WriteLine();
        }

        public void PreOrderTraversalHelper(Node<T> currentNode)
        {
            if (currentNode != null)
            {
                Console.Write(currentNode.Value + ", ");//N
                PreOrderTraversalHelper(currentNode.Left);//L
                PreOrderTraversalHelper(currentNode.Right);//R
            }
        }


        public void PostOrderTraversal()
        {
            PostOrderTraversalHelper(root);
            Console.WriteLine();
        }

        public void PostOrderTraversalHelper(Node<T> currentNode)
        {
            if (currentNode != null)
            {
                PostOrderTraversalHelper(currentNode.Left);//L
                PostOrderTraversalHelper(currentNode.Right);//R
                Console.Write(currentNode.Value + ", ");//N
            }
        }

        public int CountLeafNodes()
        {
            return CountLeafNodesHelper(root);
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

        public int Height()
        {
            return HeightHelper(root);
        }

        public int HeightHelper(Node<T> currentNode)
        {
            if(currentNode==null)
            {
                return -1;
            }
            else
                return 1 + Math.Max(HeightHelper(currentNode.Left), HeightHelper(currentNode.Right) );
        }

        public int CountNodes()
        {
            return CountHelper(root);
        }

        public int CountHelper(Node<T> currentNode)
        {
            if (currentNode == null)
                return 0;
            else
                return CountHelper(currentNode.Left) + CountHelper(currentNode.Right) + 1;
        }

        public void PrintAllPaths()
        {
            Console.WriteLine("Printing all paths ...");
            if(root != null)
                PrintAllPathsHelper(root, "");
            else
                Console.WriteLine("The tree is empty, no paths found");
            Console.WriteLine("=========================");
        }

        public void PrintAllPathsHelper(Node<T> currentNode, string PathSoFar )
        {
            if (currentNode.Left != null)
                PrintAllPathsHelper(currentNode.Left, PathSoFar + ", " + currentNode.Value);
            if (currentNode.Right != null)
                PrintAllPathsHelper(currentNode.Right, PathSoFar + ", " + currentNode.Value);
            if(currentNode.Left==null && currentNode.Right==null)
                Console.WriteLine(PathSoFar + ", " + currentNode.Value);//end of the path - the leaf
        }
        //ctor
        //public BST()
        //{
        //    root = null;
        //    Count = 0;
        //}
    }
}
