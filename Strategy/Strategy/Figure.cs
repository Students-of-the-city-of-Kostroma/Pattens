using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Figure
    {
        private IStrategy _strategy;
        public Figure(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public string WhatIsIt()
        {
            return _strategy.WhatIsIt();
        }
    }
}
