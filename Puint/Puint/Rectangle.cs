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
    public class Rectangli: Figures
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
        public Rectangli()
        {
        }
        public Rectangli(Color color, Point OldPoint, Point NewPoint, float size)
        {
            oldPoint = OldPoint;
            newPoint = NewPoint;
            _color = color;
            _size = size;
        }
        public override void Draw(Graphics gr, float size)
        {
            if(oldPoint!=null && newPoint != null)
            {
                if (newPoint.X < oldPoint.X && newPoint.Y < oldPoint.Y)
                {
                    Point p = newPoint;
                    newPoint = oldPoint;
                    oldPoint = p;
                }
                else if (newPoint.X < oldPoint.X && newPoint.Y > oldPoint.Y)
                {
                    int p = oldPoint.X;
                    oldPoint.X = newPoint.X;
                    newPoint.X = p;
                }
                else if (newPoint.X > oldPoint.X && newPoint.Y < oldPoint.Y)
                {
                    int p = oldPoint.Y;
                    oldPoint.Y = newPoint.Y;
                    newPoint.Y = p;
                }
                Pen pen = new Pen(_color, _size);
                Rectangle r = new Rectangle(oldPoint, new Size(newPoint.X - oldPoint.X, newPoint.Y - oldPoint.Y));
                gr.DrawRectangle(pen, r);
            }
        }
        public static void Draw(Graphics gr,Color color, Point OldPoint, Point NewPoint, float size)
        {
            Pen pen = new Pen(color, size);
                if (NewPoint.X < OldPoint.X && NewPoint.Y < OldPoint.Y)
                {
                    Point p = NewPoint;
                    NewPoint = OldPoint;
                    OldPoint = p;
                }
                else if (NewPoint.X < OldPoint.X && NewPoint.Y > OldPoint.Y)
                {
                    int p = OldPoint.X;
                    OldPoint.X = NewPoint.X;
                    NewPoint.X = p;
                }
                else if (NewPoint.X > OldPoint.X && NewPoint.Y < OldPoint.Y)
                {
                    int p = OldPoint.Y;
                    OldPoint.Y = NewPoint.Y;
                    NewPoint.Y = p;
                }
                Rectangle r = new Rectangle(OldPoint, new Size(NewPoint.X - OldPoint.X, NewPoint.Y - OldPoint.Y));
                gr.DrawRectangle(pen, r);
        }
    }
}
