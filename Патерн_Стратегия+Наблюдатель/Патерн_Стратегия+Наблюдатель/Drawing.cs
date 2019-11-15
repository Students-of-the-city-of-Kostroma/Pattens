using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Патерн_Стратегия_Наблюдатель
{
    class Drawing : IObserverable
    {
        public IStrategy StrategyForStartCap { get; set; }
        public IStrategy StrategyForEndCap { get; set; }
        private List<IObserver> listObservers = new List<IObserver>();       

        public Drawing()
        {
            StrategyForStartCap = new StrategyArrow();
            StrategyForEndCap = new StrategyArrow();
        }

        public void DrawLine(Graphics g, Point curPoint, Point prePoint)
        {
            using(Pen p = new Pen(Color.Black))
            {
                CustomLineCap capStart = StrategyForStartCap.DrawLine();
                CustomLineCap capEnd = StrategyForEndCap.DrawLine();

                if (capStart != null)
                    p.CustomStartCap = capStart;                
                if(capEnd != null)
                    p.CustomEndCap = capEnd;

                g.DrawLine(p, curPoint, prePoint);
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver o)
        {
            listObservers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            listObservers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver element in listObservers)
                element.Update(StrategyForStartCap, StrategyForEndCap);                
        }        
    }    

    interface IObserverable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
