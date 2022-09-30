using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.IO;


namespace ConwaysGameofLife
{
    class Life
    {
        int Size;

        int Pool;
  
        Point[] Moves { get; set; }

        bool Living { get; set; }

        Dictionary<Point, int> Positions { get; set; }

        public void Coordinates()
        {
            Random r = new Random();

            // Create grid and store coordinates
            for (int i = 0; i < Size*Size; i++)
            {
                int row = i / Size;
                int col = i % Size;
                
                Positions.Add(new Point(row, col), r.Next(2));
            }

            // Create First Form
            Positions[new Point(1, 3)] = 1;
            Positions[new Point(1, 4)] = 1;
            Positions[new Point(2, 4)] = 1;
            Positions[new Point(2, 5)] = 1;

            // Create Second Form
            Positions[new Point(5, 3)] = 1;
            Positions[new Point(5, 4)] = 1;
            Positions[new Point(6, 2)] = 1;
            Positions[new Point(6, 3)] = 1;
            Positions[new Point(7, 5)] = 1;
            Positions[new Point(8, 4)] = 1;

            Positions[new Point(12, 12)] = 1;
            Positions[new Point(13, 11)] = 1;
            Positions[new Point(13, 13)] = 1;
            Positions[new Point(14, 12)] = 1;

            Positions[new Point(8, 8)] = 1;
            Positions[new Point(8, 9)] = 1;
            Positions[new Point(8, 10)] = 1;
        }

        public int Neighbors(Point point)
        {
            // Keep track of neighbor count
            int count = 0;

            // Neighbor cell
            Point nextPoint;

            // Iterate grid
            for (int i = 0; i < Moves.Length; i++)
            {
                // Check neighboring coordinates
                nextPoint = new Point(Moves[i].X + point.X, Moves[i].Y + point.Y);

                // Boundary conditions
                bool inXBounds = nextPoint.X > -1 && nextPoint.X < Size;
                bool inyBounds = nextPoint.Y > -1 && nextPoint.Y < Size;

                // Check if in bounds
                if (inXBounds && inyBounds && (point != nextPoint))
                {
                    // If there is a neighbor
                    if (Positions[nextPoint] == 1)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public void PrintItAll()
        {
            Console.WriteLine();
            // Print positions
            foreach (var point in Positions)
            {
                if (point.Value != 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }

                if (point.Key.Y % Size == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        public void Create(int nthreads, int finalTime)
        {
            
            if (finalTime < 0)
            {
                return;
            }

            // Iterate to a number of FinalTime
            Create(nthreads, finalTime - 1);

            // Grow life after creation
            Positions = new Dictionary<Point, int>(ThreadIt(nthreads));


        }

        public int Grow(Point point)
        {

            // Check and Print positions
            Living = Positions[point] == 1;

            // Call once per time step
            int count = Neighbors(point);

            // If not over/underpopulated
            if ((count == 2 && Living) || count == 3)
            {
                // Keep living or come to life 
                return 1;
            }
            
            // Death
            return 0;
        }

        // Struct for function arguments
        struct Args
        {
            public int id;
            public int pool;
            public int nthreads;
            public Dictionary<Point, int> tempiverse;
        };

        // Multithreading
        public Dictionary<Point, int> ThreadIt(int nthreads)
        {
            // Create a thread array
            Thread[] threads = new Thread[nthreads];

            // Universe during transition to S'
            Dictionary<Point, int> Tempiverse = new Dictionary<Point, int>(Positions);

            // Partition data evenly among threads
            Pool = Size / nthreads;

            // Account for N not evenly divisible by P
            if (Size % nthreads != 0)
            {
                // Partition data n/p-1 + 1 
                Pool = Size / (nthreads - 1) + 1;
            }

            PrintItAll();

            // Run Parallelization
            for (int i = 0; i < nthreads; i++)
            {
                // Argument Structure to pass to threads
                Args args = new Args();

                // Thread id
                args.id = i;

                // Pool size
                args.pool = Pool;

                // Temporary transition
                args.tempiverse = Tempiverse;

                // number of threads
                args.nthreads = nthreads;

                // i'th thread method for executing
                threads[i] = new Thread(SPrime);

                // Start thread and pass arguments
                threads[i].Start(args);
            }

            // Join threads
            for (int i = 0; i < nthreads; i++)
            {
                threads[i].Join();
            }

            return Tempiverse;
        }

        public void SPrime(object _args)
        {
            // Type cast from struct
            Args args = (Args)_args;
            
            // Thread id
            int id = args.id;

            // Number of threads
            int nthreads = args.nthreads;

            // Loop start and stop
            int start = args.pool * id;
            int stop = args.pool + start;
            if (id - 1 == nthreads)
            {
                stop = Size;
            }

            // Next State
            int y = start;

            // Temporary Grid
            Dictionary<Point, int> temp = args.tempiverse;

            // Run through grid O(n) and O(1) access
            foreach (var point in temp)
            {

                Point tempPoint = new Point(point.Key.X, y);

                try
                {
                    Monitor.Enter(this);
                    temp[tempPoint] = Grow(tempPoint);
                }
                finally
                {
                    Monitor.Exit(this);
                }

                y++;

                if (y >= stop)
                {
                    y = start;
                }
            }
        }
        
        // Constructors
        public Life()
        {
            Size = 20;

            Moves = new Point[] {
                new Point(-1, 0),
                new Point(1, 0),
                new Point(0, 1),
                new Point(0, -1),
                new Point(-1, -1),
                new Point(-1, 1),
                new Point(1, 1),
                new Point(1, -1)
            };

            Positions = new Dictionary<Point, int>();

            Coordinates();
        }

        public Life(int _Size)
        {
            Size = _Size;
            
            Moves = new Point[] {
                new Point(-1, 0),
                new Point(1, 0),
                new Point(0, 1),
                new Point(0, -1),
                new Point(-1, -1),
                new Point(-1, 1),
                new Point(1, 1),
                new Point(1, -1)
            };

            Positions = new Dictionary<Point, int>();

            Coordinates();
        }
    }
}
