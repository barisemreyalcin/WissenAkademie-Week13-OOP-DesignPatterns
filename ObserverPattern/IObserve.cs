using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserve
    {
        public void Update();

        public void setSubject(ISubject subject);
    }
}
