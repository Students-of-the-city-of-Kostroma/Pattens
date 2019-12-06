using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class LineRomb : LineEnd
    {
        public LineRomb(): base()
        {
        }
        public override string outpat()
        {
            return base.outpat() + ",\tRomb\n";
        }
    }
}
