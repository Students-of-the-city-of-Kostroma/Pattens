using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace pnt
{
    [Serializable]
    public class Ellipse
    {
        public Ellipse()
        {

        }

        public Ellipse(Point p, double wd, double hd, Color clr, float lnwd)
        {
            point = p;
            width = wd;
            heigth = hd;
            color = clr.ToArgb();
            linewidth = lnwd;
        }

        public Point point { get; set; }
        public double width { get; set; }
        public double heigth { get; set; }
        public int color { get; set; }
        public float linewidth { get; set; }
    }
}
