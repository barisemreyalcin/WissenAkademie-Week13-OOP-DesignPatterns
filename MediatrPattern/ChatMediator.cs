using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediatrPattern
{
    public class ChatMediator : IChatMediator
    {
        private List<User> users;

        public ChatMediator() 
        {
            users = new List<User>();
        }
        public void addUser(User user)
        {
            users.Add(user);
        }

        public void sendMessage(string msg, User user)
        {
            foreach (var item in users) 
            {
                if (user != item)
                    user.Receive(msg,item);
            }
        }
    }
}
