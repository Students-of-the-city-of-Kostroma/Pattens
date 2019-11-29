using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Патерн_Стратегия_Наблюдатель
{
    class Drawing
    {
        public IStrategy StrategyForStartCap { get; set; }
        public IStrategy StrategyForEndCap { get; set; }
        private Observer observer;
        public Observer Observer
        {
            get
            {
                return observer;
            }
            set
            {
                observer = value;
                ChangeDrawing += observer.ChangeUpdate;
            }
        }
        public event EventHandler ChangeDrawing;

        public Drawing()
        {
            StrategyForStartCap = new StrategyArrow();
            StrategyForEndCap = new StrategyArrow();            
        }

        public void DrawLine(Graphics g, Point curPoint, Point prePoint)
        {
            using (Pen p = new Pen(Color.Black))
            {
                CustomLineCap capStart = StrategyForStartCap.DrawLine();
                CustomLineCap capEnd = StrategyForEndCap.DrawLine();

                if (capStart != null)
                    p.CustomStartCap = capStart;
                if (capEnd != null)
                    p.CustomEndCap = capEnd;

                g.DrawLine(p, curPoint, prePoint);

                object s = new IStrategy[] { StrategyForStartCap, StrategyForEndCap };
                ChangeDrawing.Invoke(s, null);
            }
        }        
    }        
}
