using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTask
{
    public class Square : IShape
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public IShape(double side)
        {
            Side1 = side;
        }

        public double GetArea(double side)
        {
            return side * side;
        }
    }
}
