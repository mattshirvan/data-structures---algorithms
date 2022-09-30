using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab10
{
    class Graph
    {
        //data  G = (Vertices, Edges)
        public List<Vertex> Vertices { get; private set; }
        public List<List<Tuple<Vertex, double>>> AdjacencyList { get; private set; }
        public bool IsDirected { get; private set; }

        public Graph(bool IsDirected)
        {
            this.IsDirected = IsDirected;
            Vertices = new List<Vertex>();
            AdjacencyList = new List<List<Tuple<Vertex, double>>>();
        }

        //methods
        public void AddVertex(string newLabel)
        {
            Vertex v1 = new Vertex(newLabel); //create a new Vertex
            Vertices.Add(v1); //add it to the list of vertices
            AdjacencyList.Add(new List<Tuple<Vertex, double>>()); //add a new row into Adjacency list
        }

        // O(n)
        public Vertex GetVertex(string label)
        {
            Vertex ret = null; //returned if label not found
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Label.CompareTo(label) == 0)
                {
                    ret = Vertices[i];
                    break;
                }
            }
            return ret;
        }

        //helper method, returns the index of a vertex (in Vertices list) with a given label
        public int FindIndex(string label)
        {
            int ret = -1; //returned if label not found
            for (int i = 0; i < Vertices.Count; i++)
            {
                if (Vertices[i].Label.CompareTo(label) == 0)
                {
                    ret = i;
                    break;
                }
            }
            return ret;
        }

        public void AddEdge(string startLabel, string endLabel, double weight = 1)
        {
            int indexStartLabel = FindIndex(startLabel);
            if (indexStartLabel == -1)
                throw new Exception($"{startLabel} not found");

            int indexEndLabel = FindIndex(endLabel);//search the Vertices list for endLabel
            if (indexEndLabel == -1) //endLabel does not exist in the Vertices list
                throw new Exception($"{endLabel} not found");

            AdjacencyList[indexStartLabel].Add(new Tuple<Vertex, double>(Vertices[indexEndLabel], weight));

            if (!IsDirected)//if the graph is not directed
            {
                AdjacencyList[indexEndLabel].Add(new Tuple<Vertex, double>(Vertices[indexStartLabel], weight));
            }
        }

        public void RemoveEdge(string startLabel, string endLabel)
        {
            int indexStartLabel = FindIndex(startLabel);
            if (indexStartLabel == -1)
                throw new Exception($"{startLabel} not found");

            int indexEndLabel = FindIndex(endLabel);//search the Vertices list for endLabel
            if (indexEndLabel == -1) //endLabel does not exist in the Vertices list
                throw new Exception($"{endLabel} not found");


            //delete the edge startLabel => endLabel
            for (int i = 0; i < AdjacencyList[indexStartLabel].Count; i++) //traverse the list
            {
                if (AdjacencyList[indexStartLabel][i].Item1.Label.CompareTo(endLabel) == 0)
                {
                    AdjacencyList[indexStartLabel].RemoveAt(i);
                    break;
                }
            }

            //if not directed
            if (!IsDirected)
            {
                //delete the edge endLabel => startLabel 
                for (int i = 0; i < AdjacencyList[indexEndLabel].Count; i++) //traverse the list
                {
                    if (AdjacencyList[indexEndLabel][i].Item1.Label.CompareTo(startLabel) == 0)
                    {
                        AdjacencyList[indexEndLabel].RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public void RemoveVertex(string someLabel)
        {
            int indexSomeLabel = FindIndex(someLabel);
            if (indexSomeLabel == -1)
                throw new Exception($"{indexSomeLabel} not found");

            //remove all references/edges from the Adjacency list
            for (int i = 0; i < AdjacencyList.Count; i++) //iterate through each list
            {
                if (i == indexSomeLabel)
                    continue;//skip this list, we'll delete it below
                else
                {
                    //search for a pair containing (Vertex(someLabel), weight) and delete
                    for (int j = 0; j < AdjacencyList[i].Count; j++)
                    {
                        if (AdjacencyList[i][j].Item1.Label.CompareTo(someLabel) == 0)
                        {
                            AdjacencyList[i].RemoveAt(j); //remove the edge
                            break;
                        }
                    }
                }
            }

            //remove the vertex from Vertices (remove position index)
            Vertices.RemoveAt(indexSomeLabel);

            //remove the list from AdjacencyList (remove list at position index)
            AdjacencyList.RemoveAt(indexSomeLabel);

        }

        public void PrintEdgesAndVertices()
        {
            //print if directed or not
            Console.WriteLine($"Is directed: {IsDirected}");

            //print Vertices
            Console.Write("Vertices: ");
            foreach (Vertex v in Vertices)
            {
                Console.Write(v.Label + " ");
            }
            Console.WriteLine();

            //print Edges
            for (int i = 0; i < AdjacencyList.Count; i++)
            {
                Console.Write(Vertices[i].Label + ":");
                foreach (var edge in AdjacencyList[i])
                    Console.Write($"({edge.Item1.Label}, {edge.Item2}) ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void BFS(Graph g, Vertex s)
        {
            // Create queue
            Queue<Vertex> q = new Queue<Vertex>();

            // Display directed graph or not
            Console.WriteLine($"Is directed: {g.IsDirected}");

            // Initialize Vertices
            Console.WriteLine("Initialize Vertices");
            foreach (Vertex v in g.Vertices)
            {
                // Mark unvisited
                v.Color = "White";

                // Infinity 
                v.D = Double.PositiveInfinity;

                // No connection
                v.Pi = null;
            }


            // Mark Source Visited
            s.Color = "Gray";

            // Initialize distance of source to 0
            s.D = 0.0;

            // No path to vertex
            s.Pi = null;

            // Add source to queue
            q.Enqueue(s);


            // Continue until all vertices and edges have been discovered
            while (q.Count > 0)
            {
                Vertex u = q.Dequeue();

                foreach (var v in g.AdjacencyList[0])
                {
                    if (v.Item1.Color == "White")
                    {
                        v.Item1.Color = "Gray";
                        v.Item1.D = u.D + 1;
                        v.Item1.Pi = u;
                        q.Enqueue(v.Item1);
                    }
                }

                u.Color = "Black";
            }

            //print Edges
            for (int i = 0; i < g.AdjacencyList.Count; i++)
            {
                Console.Write(g.Vertices[i].Label + ":");
                foreach (var edge in g.AdjacencyList[i])
                    Console.Write($"({edge.Item1.Label}, {edge.Item2}) ");
                Console.WriteLine();
            }
        }

    }
}
