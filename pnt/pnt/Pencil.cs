using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace pnt
{
    public class Pencil
    {
        public Pencil()
        {

        }

        public Pencil(Point p1, Point p2, Color clr, float lnwd)
        {
            point1 = p1;
            point2 = p2;
            color = clr.ToArgb();
            linewidth = lnwd;
        }

        public Point point1 { get; set; }
        public Point point2 { get; set; }
        public int color { get; set; }
        public float linewidth { get; set; }
    }
}
