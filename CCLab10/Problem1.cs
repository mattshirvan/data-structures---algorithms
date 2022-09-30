using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab10
{
    class Problem1
    {
        /*
         * Problem 1 -Route Between Nodes: 
         * Given a directed graph, 
         * design an algorithm to find out whether there is a route between two nodes.
         */
        public bool RouteBetweenNodes(Graph g, Vertex s, Vertex d)
        {
            if (s == d)
            {
                return s == d;
            }

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
                        // Path found
                        if (v.Item1 == d)
                        {
                            return v.Item1 == d;
                        }
                        else
                        {
                            v.Item1.Color = "Gray";
                            v.Item1.D = u.D + 1;
                            v.Item1.Pi = u;
                            q.Enqueue(v.Item1);
                        }
                    }
                }

                u.Color = "Black";
            }

            // No path between nodes
            return false;
        }
    }
}
