using System;

namespace CCLab4
{
    class Program
    {
        
        static void Main(string[] args)
        {

            // Problem 2 - Palindrome 
            Console.WriteLine("Problem 2 - Palindrome");
            Problem2 p2 = new Problem2();
            Console.WriteLine(p2.PalindromeSLL(p2.TestPalind1())); // Should return true
            Console.WriteLine(p2.PalindromeSLL(p2.TestPalind2())); // Should return false
            Console.WriteLine(p2.PalindromeSLL(p2.TestPalind3())); // Should return false
            Console.WriteLine();

            // Problem 3 - Intersection of Two Linked Lists
            Console.WriteLine("Problem 3 - Intersection of Two Linked Lists");
            Problem3 p3 = new Problem3();
            Node<int> test1 = p3.Instersection(p3.TestIntersection1().Head, p3.TestIntersection2().Head);
            Node<int> test2 = p3.Instersection(p3.TestIntersection1().Head, p3.TestIntersection3().Head);
            Node<int> test3 = p3.Instersection(p3.TestIntersection2().Head, p3.TestIntersection3().Head);
            Node<int> test4 = p3.Instersection(p3.TestIntersection1().Head, p3.TestIntersection4().Head);
            Node<int> test5 = p3.Instersection(p3.TestIntersection2().Head, p3.TestIntersection4().Head);
            Node<int> test6 = p3.Instersection(p3.TestIntersection3().Head, p3.TestIntersection4().Head);
            
            // Run test cases
            Console.WriteLine($"Case 1: {test1}");
            Console.WriteLine($"Case 2: {test2.Value}");
            Console.WriteLine($"Case 3: {test3}");
            Console.WriteLine($"Case 4: {test4}");
            Console.WriteLine($"Case 5: {test5}");
            Console.WriteLine($"Case 6: {test6.Value}");
            Console.WriteLine();

            // Problem 4 - Google One and Print 
            Console.WriteLine("Problem 4 - Google One and Print");
            Problem4 p4 = new Problem4();
            p4.OnePrint(p4.TestOP1()); 
            p4.OnePrint(p4.TestOP2()); 
            p4.OnePrint(p4.TestOP3());
        }
    }
}
