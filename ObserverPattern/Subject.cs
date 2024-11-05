using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private List<IObserve> observers;
        private string message;
        private bool change;
        public object context = new object();

        public Subject()
        {
            observers = new List<IObserve>();
        }

        public object getUpdate(IObserve observe)
        {
            return message;
        }

        public void notifyObserver()
        {
            List<IObserve> obs = null; 
            lock(context)
            {
                if (!change)
                    return;
            }
            obs = new List<IObserve>(observers);
            change = false;
            foreach (IObserve item in obs)
            {
                item.Update();
            }
            
        }

        public void register(IObserve observe)
        {
            if (observe == null)
                throw new Exception("Null Observer");
            else
            {
                lock(context)
                {
                    if(!observers.Contains(observe))
                        observers.Add(observe);
                }

            }
        }

        public void unregister(IObserve observe)
        {
           lock(context)
            {
                observers.Remove(observe);
            }
        }

        public void postMessage(string msg)
        {
            Console.WriteLine($"Message Posted to Topic : {msg}");
            message = msg;
            change = true;
            notifyObserver();
        }
    }
}
