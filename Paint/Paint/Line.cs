using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace Paint
{
    public class Line : Figure
    {
        [DataContract]
        public class Line : Figura
        {
            [DataMember]
            private Point _LPoint;
            [DataMember]
            private Point _NPoint;
            [DataMember]
            private Color _Acolor;
            //static Graphics ps;

            public override Point LPoint
            {
                get { return _LPoint; }
            }
            public override Point NPoint
            {
                get { return _NPoint; }
            }
            public override Color Acolor
            {
                get { return _Acolor; }
            }
            public Line()
            {

            }
            public Line(Color Acolor, Point LPoint, Point NPoint)
            {
                _LPoint = LPoint;
                _NPoint = NPoint;
                _Acolor = Acolor;
            }

            public override void Draw(Graphics ps)
            {
                if (_LPoint != null && _NPoint != null)
                {
                    Pen pen = new Pen(_Acolor, 1);
                    ps.DrawLine(pen, _LPoint, _NPoint);
                }
            }
            public static void Draw(Graphics ps, Color Acolor, Point LPoint, Point NPoint)
            {
                Pen pen = new Pen(Acolor, 1);
                ps.DrawLine(pen, LPoint, NPoint);
            }
        }
    }
}
