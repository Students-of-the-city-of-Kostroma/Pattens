using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class Coord
    {
        public abstract int X1 { get; set; }
        public abstract int Y1 { get; set; }
        public abstract int X2 { get; set; }
        public abstract int Y2 { get; set; }
        public abstract string GetCap();
    }
}
