using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab10
{
    class Problem2
    {
        /*
         * Problem 2 - Count "odd vertices" : 
         * Given an undirected graph, and a vertex, 
         * design an algorithm that will return the number of vertices that contain an odd value, 
         * and are connected (through some path) to the given vertex.
         */

        public int OddVertices(Graph g, Vertex s)
        {

            // Keep count
            int count = 0;

            // Check Undirected
            if (g.IsDirected)
            {
                return count;
            }

            // Create queue
            Queue<Vertex> q = new Queue<Vertex>();

            // Initialize Vertices
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
                        if (v.Item1.D % 2 != 0)
                        {
                            count++;
                        }

                        v.Item1.Color = "Gray";
                        v.Item1.D = u.D + 1;
                        v.Item1.Pi = u;
                        q.Enqueue(v.Item1);
                    }
                }

                u.Color = "Black";
            }

            // No path between nodes
            return count;
        }
    }   
}
