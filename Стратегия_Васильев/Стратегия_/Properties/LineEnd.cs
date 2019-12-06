using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class LineEnd
    {

        int x, y;
        public LineEnd()
        {
            Random rand = new Random();
            x = rand.Next(-100, 101);
            y = rand.Next(-100, 101);
        }
        public virtual string outpat()
        {
            return "x=" + x + ",\ty=" + y;
        }
    }
}
