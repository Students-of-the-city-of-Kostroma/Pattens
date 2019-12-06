using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Line
    {
        LineEnd linestart, lineend;

        public Line(LineEnd a, LineEnd b)
        {
            linestart = a;
            lineend = b;
        }
        public void SetStartLine(LineEnd a)
        {
            linestart = a;
        }
        public void SetEndLine(LineEnd a)
        {
            lineend = a;
        }
        public string OutPutLine()
        {

            return linestart.outpat() + lineend.outpat();
        }
    }
}
