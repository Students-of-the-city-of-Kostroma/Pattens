using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace Puint
{
    [DataContract]
    abstract public class Figures //Strategy
    {
        public abstract void Draw(Graphics gr, float size);
        public abstract Point OldPoint { get; }
        public abstract Point NewPoint { get; }
        public abstract Color color { get; }
        public abstract float size { get; }
    }
}
