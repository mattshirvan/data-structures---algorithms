using System;

namespace ConwaysGameofLife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the number of threads
            Console.WriteLine("Enter the number of threads");
            int nthreads = Convert.ToInt32(Console.ReadLine());

            // Get the Final Time
            Console.WriteLine("Enter the total time to run life");
            int finalTime = Convert.ToInt32(Console.ReadLine());

            Life life = new Life();
            
            life.Create(nthreads, finalTime);
            life.PrintItAll();
        }
    }
}
