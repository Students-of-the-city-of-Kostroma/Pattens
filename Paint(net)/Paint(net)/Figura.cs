using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace Paint_net_
{
    [DataContract]
    abstract public class Figura
    {
        public abstract void Draw(Graphics ps);
        public abstract Point LastPoint { get; }
        public abstract Point NextPoint { get; }
        public abstract Color ActiveColor { get; }
    }
}
