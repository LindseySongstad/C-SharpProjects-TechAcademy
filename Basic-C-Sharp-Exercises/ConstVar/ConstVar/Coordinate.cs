using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Coordinate
    {
        public int X;
        public int Y;
        
        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Coordinate(int x) : this(x, 0) 
        {
        }

    }
}
