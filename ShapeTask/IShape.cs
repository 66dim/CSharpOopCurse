using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTask
{
    public class IShape
    {
        public IShape()
        {
            
        }

        public virtual double GetWidth()
        {
            return 0;
        }

        public virtual double GetHeight()
        {
            return 0;
        }
        
        public virtual double GetArea()
        {
            return 0;
        }

        public virtual double GetPerimeter()
        {
            return 0;
        }
    }
}
