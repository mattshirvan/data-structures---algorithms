using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Drawing;

namespace MandelbrotSet
{
    class Mandelbrot
    {
        int Size { get; set; }
        int[,] image { get; set; }
        Bitmap bitmap { get; set; }
        List<Color> colors { get; set; }
        int MaxIteration { get; set; }

        public void Draw()
        {
            bitmap = new Bitmap(Size, Size);

            for (var x = 0; x < bitmap.Width; x++)
            {
                for (var y = 0; y < bitmap.Height; y++)
                {
                    bitmap.SetPixel(x, y, colors[image[x, y]]);
                }
            }

            bitmap.Save("C:\\Users\\User\\source\\repos\\AlgoBigO\\MandelbrotSet\\m.bmp");
        }

        public void Init_Colors()
        {
            double inc = 255.0 / Size;
            
            for (int i = 0; i < Size; i++)
            {
                int delta = (int)inc * i;
                colors.Add(Color.FromArgb(delta, 255%(1+delta), 255 - delta));

            }
        }

        public void RunMandelbrot()
        {
            
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    image[row, col] = Compute(row, col);
                }
            }
            Draw();
        }

        public int Compute(int row, int col)
        {
            int i;
            Complex z = Complex.Zero;
            Complex cc = new Complex(scale(row), scale(col)); 
            for (i = 0; i < MaxIteration; i++)
            {
                z = z * z + cc;
                if (Complex.Abs(z) >= 2.0)
                {
                    return i;
                }
            }
            return i;
        }

        public double scale(int x)
        {
            return 2 * ((x - 0) / (Size - 0)) - 2; 
        }

        public Mandelbrot()
        {
            MaxIteration = 1000;
            Size = 400;
            image = new int[Size, Size];
            colors = new List<Color>();
            Init_Colors();
            bitmap = new Bitmap(Size, Size);
        }
    }
}
