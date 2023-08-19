using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTask
{
    public class IShape
    {
        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public IShape()
        {
            //Side1 = side1;
            //Side2 = side2;
        }

        public double GetArea()
        {
        return 0;
        }
    }
}
