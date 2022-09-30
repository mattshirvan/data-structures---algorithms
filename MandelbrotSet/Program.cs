using System;

namespace MandelbrotSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Mandelbrot m = new Mandelbrot();
            m.RunMandelbrot();
        }
    }
}
