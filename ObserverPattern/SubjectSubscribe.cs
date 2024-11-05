using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class SubjectSubscribe : IObserve
    {
        private string name;
        private ISubject topic;

        public SubjectSubscribe(string _name)
        {
            name = _name;
        }
        public void setSubject(ISubject subject)
        {
            topic = subject;
        }

        public void Update()
        {
            string msg = (string)topic.getUpdate(this);
            if (msg == null)
                Console.WriteLine($"{name} : : No new Message");
            else
                Console.WriteLine($"{name} : : Consume Message : {msg}");
        }
    }
}
