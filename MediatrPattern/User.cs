using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MediatrPattern
{
    public abstract class User
    {
        protected IChatMediator mediator;
        public string name;

        public User(IChatMediator _mediator, string _name)
        {
            this.mediator = _mediator;
            this.name = _name;
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg,User user);
    }
}
