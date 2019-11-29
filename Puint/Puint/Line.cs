using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace Puint
{
    [DataContract]
    public class Line: Figures
    {
        [DataMember]
        private Point oldPoint;
        [DataMember]
        private Point newPoint;
        [DataMember]
        private Color _color;
        [DataMember]
        private float _size;

        public override Point OldPoint
        {
            get { return oldPoint; }
        }
        public override Point NewPoint
        {
            get { return newPoint; }
        }
        public override Color color
        {
            get { return _color; }
        }
        public override float size
        {
            get { return _size; }
        }
        public Line()
        {
        }
        public Line(Color color, Point OldPoint, Point NewPoint, float size)
        {
            oldPoint = OldPoint;
            newPoint = NewPoint;
            _color = color;
            _size = size;
        }
        public override void Draw(Graphics gr, float size)
        {
            if (oldPoint != null && newPoint != null)
            {
                Pen pen = new Pen(_color, size);//создаем перо с нашим цветом и размеров
                gr.DrawLine(pen, NewPoint, OldPoint);//соединяем точки линией
            }
        }
        public static void Draw(Graphics gr, Color color, Point OldPoint, Point NewPoint, float size)
        {
            Pen pen = new Pen(color, size);
            gr.DrawLine(pen, OldPoint, NewPoint);
        }
    }
}
