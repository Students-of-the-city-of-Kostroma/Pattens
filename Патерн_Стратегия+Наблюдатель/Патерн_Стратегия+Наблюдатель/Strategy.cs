using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Патерн_Стратегия_Наблюдатель
{
    class Strategy : IStrategy
    {
        public CustomLineCap DrawLine()
        {
            return null;
        }
    }

    class StrategyArrow : IStrategy
    {
        public CustomLineCap DrawLine()
        {
            GraphicsPath strokePath = new GraphicsPath();
            strokePath.AddLine(0, 0, -4, -8);
            strokePath.AddLine(0, 0, 4, -8);

            return new CustomLineCap(null, strokePath);
        }
    }

    class StrategyTriangle : IStrategy
    {
        public CustomLineCap DrawLine()
        {
            GraphicsPath fillPath = new GraphicsPath();

            fillPath.AddLine(0, 0, -2, -4);
            fillPath.AddLine(-2, -4, 2, -4);
            fillPath.AddLine(2, -4, 0, 0);

            return new CustomLineCap(fillPath, null);
        }
    }

    interface IStrategy
    {
        CustomLineCap DrawLine();
    }
}
