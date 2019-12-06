using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Line
    {
        LineEnd linestart, lineend;
        int Line_length;

        public Line(LineEnd a, LineEnd b, int line_length)
        {
            linestart = a;
            lineend = b;
            Line_length = line_length;
        }
        public void SetStartLine(LineEnd a)
        {
            linestart = a;
        }
        public void SetEndLine(LineEnd a)
        {
            lineend = a;
        }
        public void SetLineLiength(int length)
        {
            Line_length = length;
        }
        public string OutPutLine()
        {
            string line="";
            for (int i=0;i<Line_length;i++)
                line += "-";
            return linestart.outpat() +line+ lineend.outpat();
        }
    }
}
