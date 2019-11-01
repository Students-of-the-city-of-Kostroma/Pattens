using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace Paint
{
    [DataContract]
    public abstract class Figure
    {
        public abstract void Draw(Graphics gr);
        public abstract Point LPoint { get; }
        public abstract Point NPoint { get; }
        public abstract Color Acolor { get; }
    }
}
