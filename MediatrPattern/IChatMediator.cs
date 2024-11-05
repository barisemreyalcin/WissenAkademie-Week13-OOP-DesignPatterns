using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrPattern
{
    public interface IChatMediator
    {
        public void sendMessage(string msg, User user);

        void addUser(User user);
    }
}
