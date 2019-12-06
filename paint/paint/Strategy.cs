using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace paint
{
    class StrategyNone : IStrategy
    {
        public LineCap cap()
        {
            return LineCap.NoAnchor;
        }
    }
    class StrategyTriangle : IStrategy
    {
        public LineCap cap()
        {
            return LineCap.Triangle;
        }
    }
    
    class StrategyArrow : IStrategy
    {
        public LineCap cap()
        {
            return LineCap.ArrowAnchor;
        }
    }
}
