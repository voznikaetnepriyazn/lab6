using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class ConcretObserver: IObserver
    {
        public void Visit(IObservable observable)
        {
            try
            {
                if (observable.GetStateOfMetric() == 0)
                    Console.WriteLine("Тревога!");
            }
            catch (Exception )
            {
                Console.WriteLine("Тревога!");
            }
        }
    }
}
