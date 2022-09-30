using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleyLinkedList<int> dll = new DoubleyLinkedList<int>();

            dll.AddFirst(8);
            dll.AddFirst(7);
            dll.AddFirst(6);
            dll.AddFirst(5);
            dll.AddFirst(4);
            dll.AddFirst(3);
            dll.AddFirst(2);
            dll.AddFirst(1);
            Console.WriteLine();
            Console.WriteLine("Initial List: O(1)");
            dll.PrintToConsole();

            Console.WriteLine("Delete First: O(1)");
            dll.DeleteFirst();
            dll.PrintToConsole();

            Console.WriteLine("Delete Last: O(1)");
            dll.DeleteLast();
            dll.PrintToConsole();

            Console.WriteLine("Delete Value: O(n)");
            dll.DeleteValue(5);
            dll.PrintToConsole();

            Console.WriteLine("Delete Node: O(1)");
            dll.DeleteNode(dll.Head.Next.Next); // should remove 4
            dll.PrintToConsole();

            Console.WriteLine("Reverse: O(n)");
            dll.Reverse();
            dll.PrintToConsole();
        }
    }
}
