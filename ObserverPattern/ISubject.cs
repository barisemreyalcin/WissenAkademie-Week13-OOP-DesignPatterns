using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        public void register(IObserve observe);
        public void unregister(IObserve observe);

        public void notifyObserver();

        public Object getUpdate(IObserve observe);
    }
}
