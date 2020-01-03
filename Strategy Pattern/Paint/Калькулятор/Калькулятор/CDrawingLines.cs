using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Калькулятор
{
    class CDrawingLines
    {
        public IStrategy StartCapCS { get; set; }
        public IStrategy EndCapCS { get; set; }

        public CDrawingLines()
        {
            StartCapCS = new CStrategy();
            EndCapCS = new CStrategy();
        }

        public void CLine(Graphics SGraphics, Point SecondP, Point FirstP)
        {
            Pen Pencil = new Pen(Color.Black, 2);
            Pencil.StartCap = LineCap.Round;
            Pencil.EndCap = LineCap.Round;
            Pencil.LineJoin = LineJoin.Round;
            using (Pencil)
            {
                CustomLineCap StartC = StartCapCS.DrawLine();
                CustomLineCap EndC = EndCapCS.DrawLine();
                if (StartC != null)
                {
                    Pencil.CustomStartCap = StartC;
                }
                if (EndC != null)
                {
                    Pencil.CustomEndCap = EndC;
                }
                SGraphics.DrawLine(Pencil, SecondP, FirstP);
            }
        }
    }
}
