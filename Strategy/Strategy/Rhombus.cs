using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Rhombus : IStrategy
    {
        public string WhatIsIt()
        {
            return "Rhombus";
        }
    }
}
