using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн_Стратегия_Наблюдатель
{
    class Observer : IObserver
    {
        private IStrategy CapStart;
        private IStrategy CapEnd;

        public void Update(IStrategy CapStart, IStrategy CapEnd)
        {
            this.CapStart = CapStart;
            this.CapEnd = CapEnd;
        }
    }

    interface IObserver
    {
        void Update(IStrategy CapStart, IStrategy CapEnd);
    }
}
