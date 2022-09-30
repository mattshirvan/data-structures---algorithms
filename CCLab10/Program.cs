using System;

namespace CCLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1 - Route Between Nodes
            Console.WriteLine("Problem 1 - Route Between Nodes");
            Problem1 p1 = new Problem1();
            Graph myGraph = new Graph(true);

            // Create Nodes
            myGraph.AddVertex("A");
            myGraph.AddVertex("B");
            myGraph.AddVertex("C");
            myGraph.AddVertex("D");
            myGraph.AddVertex("E");

            // Create weighted edges
            myGraph.AddEdge("A", "C", 40);
            myGraph.AddEdge("A", "B", 30);
            myGraph.AddEdge("A", "D", 90);
            myGraph.AddEdge("A", "E", 100);
            myGraph.AddEdge("B", "C", 80);
            myGraph.AddEdge("B", "D", 20);
            myGraph.AddEdge("B", "E", 100);
            myGraph.AddEdge("C", "D", 10);
            myGraph.AddEdge("C", "E", 30);
            myGraph.AddEdge("D", "E", 10);

            myGraph.PrintEdgesAndVertices();

            bool route = p1.RouteBetweenNodes(myGraph, myGraph.GetVertex("A"), myGraph.GetVertex("E"));
            Console.WriteLine(route);
            route = p1.RouteBetweenNodes(myGraph, myGraph.GetVertex("A"), myGraph.GetVertex("C"));
            Console.WriteLine(route);

            // Problem 2 - Count odd vertices
            Console.WriteLine("Problem 2 - Count odd vertices");
            Problem2 p2 = new Problem2();

            Graph g = new Graph(false);

            // Create Nodes
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");

            // Create weighted edges
            g.AddEdge("A", "C", 40);
            g.AddEdge("A", "B", 30);
            g.AddEdge("A", "D", 90);
            g.AddEdge("A", "E", 100);
            g.AddEdge("B", "C", 80);
            g.AddEdge("B", "D", 20);
            g.AddEdge("B", "E", 100);
            g.AddEdge("C", "D", 10);
            g.AddEdge("C", "E", 30);
            g.AddEdge("D", "E", 10);

            g.PrintEdgesAndVertices();

            Console.WriteLine(p2.OddVertices(g, g.GetVertex("A")));

            // Problem 3 - Count descendants
            Console.WriteLine("Problem 3 - Count descendants");
            Problem3 p3 = new Problem3();
            Console.WriteLine(p3.CountDescendants(myGraph, myGraph.GetVertex("A")));
        }
    }
}
