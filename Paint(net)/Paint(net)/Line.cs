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
    public class Line : Figura
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
        public Line()
        {

        }
        public Line(Color ActiveColor, Point LastPoint, Point NextPoint)
        {
            _LastPoint = LastPoint;
            _NextPoint = NextPoint;
            _ActiveColor = ActiveColor;
        }

        public override void Draw(Graphics ps)
        {
            if (_LastPoint != null && _NextPoint != null)
            {
                Pen pen = new Pen(_ActiveColor, 1);
                ps.DrawLine(pen, _LastPoint, _NextPoint);
            }
        }
        public static void Draw(Graphics ps, Color ActiveColor, Point LastPoint, Point NextPoint)
        {
            Pen pen = new Pen(ActiveColor, 1);
            ps.DrawLine(pen, LastPoint, NextPoint);
        }
    }
}