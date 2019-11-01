using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pnt
{
    [Serializable]
    public class Panel
    {
        public Panel()
        {

        }
        public Panel(Pencil[] pen = null, Square[] square = null, Ellipse[] ellipse = null)
        {
            this.ellipse = ellipse;
            this.square = square;
            this.pen = pen;
        }
        public Ellipse[] ellipse { get; set; }
        public Square[] square { get; set; }
        public Pencil[] pen { get; set; }
    }
}
