using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Калькулятор
{
    interface IStrategy
    {
        CustomLineCap DrawLine();
    }

    class CStrategy : IStrategy
    {
        public CustomLineCap DrawLine()
        {
            return null;
        }
    }

    class ArrowCStrategy : IStrategy
    {
        public CustomLineCap DrawLine()
        {
            GraphicsPath CArrow = new GraphicsPath();
            CArrow.AddLine(0, 0, -3, -5);
            CArrow.AddLine(0, 0, 3, -5);

            return new CustomLineCap(null, CArrow);
        }
    }

    class TriangleCStrategy : IStrategy
    {
        public CustomLineCap DrawLine()
        {
            GraphicsPath CTriangle = new GraphicsPath();

            CTriangle.AddLine(0, 0, -4, -6);
            CTriangle.AddLine(-4, -6, 4, -6);
            CTriangle.AddLine(4, -6, 0, 0);

            return new CustomLineCap(CTriangle, null);
        }
    }
}
