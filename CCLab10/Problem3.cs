using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab10
{
    class Problem3
    {
        /*
         * Problem 3 - Count descendants: 
         * Given a directed graph, and a vertex, 
         * design an algorithm that will return the number of descendants 
         * (not including itself) from that given vertex.
         */

        // O(n)
        public int CountDescendants(Graph g, Vertex s)
        {
            // Get the index of the vertex in the Adj. List
            int index = g.FindIndex(s.Label);

            // Count of descendants
            int count = 0;

            // Run through reachable nodes from source s
            foreach (var edge in g.AdjacencyList[index])
            {
                count++;
            }

            return count;
        }
    }
}
