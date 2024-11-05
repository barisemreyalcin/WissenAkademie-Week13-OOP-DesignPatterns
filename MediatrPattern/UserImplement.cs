using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrPattern
{
    public class UserImplement : User
    {
        public UserImplement(IChatMediator mediator, string name) : base(mediator, name)
        {

        }
        public override void Receive(string msg,User user)
        {
            Console.WriteLine($"{name} : Receive Message : {msg} - Receive User : {user.name}");
        }

        public override void Send(string msg)
        {
            Console.WriteLine($"{name} : Sending Message : {msg} - Send User : {this.name}");
            mediator.sendMessage(msg, this);
        }
    }
}
