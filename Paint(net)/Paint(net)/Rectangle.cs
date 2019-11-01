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
    public class Rect : Figura
    {
        [DataMember]
        private Point _LastPoint;
        [DataMember]
        private Point _NextPoint;
        [DataMember]
        private Color _ActiveColor;
        //static Graphics ps;

        public override Point LastPoint
        {
            get { return _LastPoint; }
        }
        public override Point NextPoint
        {
            get { return _NextPoint; }
        }
        public override Color ActiveColor
        {
            get { return _ActiveColor; }
        }
        public Rect()
        {

        }
        public Rect(Color ActiveColor, Point LastPoint, Point NextPoint)
        {
            _LastPoint = LastPoint;
            _NextPoint = NextPoint;
            _ActiveColor = ActiveColor;
        }

        public override void Draw(Graphics ps)
        {
            if (_LastPoint != null && _NextPoint != null)
            {
                if (_NextPoint.X < _LastPoint.X && _NextPoint.Y < _LastPoint.Y)
                {
                    Point c = _NextPoint;
                    _NextPoint = _LastPoint;
                    _LastPoint = c;
                }
                else if (_NextPoint.X < _LastPoint.X && _NextPoint.Y > _LastPoint.Y)
                {
                    int c = _LastPoint.X;
                    _LastPoint.X = _NextPoint.X;
                    _NextPoint.X = c;
                }
                else if (_NextPoint.X > _LastPoint.X && _NextPoint.Y < _LastPoint.Y)
                {
                    int c = _LastPoint.Y;
                    _LastPoint.Y = _NextPoint.Y;
                    _NextPoint.Y = c;
                }
                Pen pen = new Pen(_ActiveColor, 1);
                Rectangle rec = new Rectangle(_LastPoint, new Size(_NextPoint.X - _LastPoint.X, _NextPoint.Y - _LastPoint.Y));
                ps.DrawRectangle(pen, rec);
            }
        }
        public static void Draw(Graphics ps, Color ActiveColor, Point LastPoint, Point NextPoint)
        {
            Pen pen = new Pen(ActiveColor, 1);
            if (NextPoint.X < LastPoint.X && NextPoint.Y < LastPoint.Y)
            {
                Point c = NextPoint;
                NextPoint = LastPoint;
                LastPoint = c;
            }
            else if (NextPoint.X < LastPoint.X && NextPoint.Y > LastPoint.Y)
            {
                int c = LastPoint.X;
                LastPoint.X = NextPoint.X;
                NextPoint.X = c;
            }
            else if (NextPoint.X > LastPoint.X && NextPoint.Y < LastPoint.Y)
            {
                int c = LastPoint.Y;
                LastPoint.Y = NextPoint.Y;
                NextPoint.Y = c;
            }
            Rectangle rec = new Rectangle(LastPoint, new Size(NextPoint.X - LastPoint.X, NextPoint.Y - LastPoint.Y));
            ps.DrawRectangle(pen, rec);
        }
    }
}
