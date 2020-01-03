using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Калькулятор
{
    public class RLine
    {
        public RLine()
        {

        }

        public RLine(Point LP, Point FP, Color EC, float BW, string StartC, string EndC)
        {
            FPoint = FP;
            LPoint = LP;
            ElColor = EC.ToArgb();
            BrushWidth = BW;
            StartCap = StartC;
            EndCap = EndC;
        }

        public Point FPoint { get; set; }
        public Point LPoint { get; set; }
        public int ElColor { get; set; }
        public float BrushWidth { get; set; }
        public string StartCap { get; set; }
        public string EndCap { get; set; }
    }
}
