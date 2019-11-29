using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Патерн_Стратегия_Наблюдатель
{
    class Observer
    {
        private IStrategy CapStart;
        private IStrategy CapEnd;             

        public void ChangeUpdate(object s, EventArgs e)
        {
            IStrategy[] strategies = s as IStrategy[];
            Update(strategies[0], strategies[1]);
        }

        private void Update(IStrategy CapStart, IStrategy CapEnd)
        {
            this.CapStart = CapStart;
            this.CapEnd = CapEnd;
        }    
    }    
}
