using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор
{
    class CAnObserver : IObserver
    {
        private IStrategy StartCap;
        private IStrategy EndCap;

        public void Update(IStrategy StartCap, IStrategy EndCap)
        {
            this.StartCap = StartCap;
            this.EndCap = EndCap;
        }
    }

    interface IObserver
    {
        void Update(IStrategy StartCap, IStrategy EndCap);
    }
}
