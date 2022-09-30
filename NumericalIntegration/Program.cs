using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NumericalIntegration
{
    class Program
    {
        /*
         /∗ Input: a, b, n ∗/
            
            h = (b−a)/n;
            
            approx = (f(a) + f(b))/2.0;

            for (int i = 1; i <= n−1; i++) 
            {
                xi = a + i∗h;
                approx += f(xi);
            }
            approx = h∗approx;
         */

        // Create f(x)
        public static double f(double x)
        {
            return (double)Math.Pow(Math.E, x);
        }

        static void Main(string[] args)
        {
            // Set global sum variable
            //long global_sum = 0;

            // Get interval a
            //Console.WriteLine("Enter interval a");
            //long a = Convert.ToInt32(Console.ReadLine());

            // Get interval b
            //Console.WriteLine("Enter interval b");
            //long b = Convert.ToInt32(Console.ReadLine());

            // Get n panels
            //Console.WriteLine("Enter interval n");
            //long n = Convert.ToInt32(Console.ReadLine());

            // Create delta x
            //long h = (b - a)/n;

            // Approximation
            //long subtotal = (f(a) + f(b)) / n;

            // create x_i
            //long x_i;

            // Use type parameter to make subtotal a long, not an int
            /*Parallel.For<long>(0, n, () => 0, (i, loop, subtotal) =>
            {
                x_i = a + i * h;
                subtotal += f(x_i);
                return subtotal;
            },
                (x) => Interlocked.Add(ref global_sum, x)
            );

            Console.WriteLine("The total is {0:N0}", global_sum);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();*/

            // Set global sum variable
            //long global_sum = 0;

            // Get interval a
            //Console.WriteLine("Enter interval a");
            //long a = Convert.ToInt32(Console.ReadLine());

            // Get interval b
            //Console.WriteLine("Enter interval b");
            //long b = Convert.ToInt32(Console.ReadLine());

            // Get n panels
            //Console.WriteLine("Enter interval n");
             n = Convert.ToInt32(Console.ReadLine());

            // Create delta x
            double h = (b - a)/n;

            // Approximation
            double subtotal = (f(a) + f(b)) / n;

            // create x_i
            double x_i;

            const int NTHREADS = 8; Thread[] threads = new Thread[NTHREADS];
            int count = 0;

            for (int i = 0; i < NTHREADS; i++)
            {
                threads[i] = new Thread((i) => { for (int j = 0; j < n; j++) { Console.WriteLine($"{++count} hello world from {j}"); } });
                Console.WriteLine($"id: {threads[i].ManagedThreadId}");
                threads[i].Start();
                threads[i].Join();
            }
        }
    }
}
