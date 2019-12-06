using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class LineArrow : LineEnd
    {
        public LineArrow() : base ()
        {
        }
        public override string outpat()
        {
            return base.outpat() + "^";
        }
    }
}
