using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLab10
{
    class Vertex
    {
        public string Label { get; set; }
        public double D { get; set; }
        public string Color { get; set; }

        public Vertex Pi { get; set; }

        public Vertex(string newLabel)
        {
            Label = newLabel;
            D = Double.PositiveInfinity;
            Color = "White";
            Pi = null;
        }
    }
}
