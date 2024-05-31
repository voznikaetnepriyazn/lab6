using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class ObservableElement: IObservable
    {
        protected int state;
        public ObservableElement(int state)
        {  
            this.state = state; 
        }
        public int GetStateOfMetric()
        {
            return state;
        }
    }
}
