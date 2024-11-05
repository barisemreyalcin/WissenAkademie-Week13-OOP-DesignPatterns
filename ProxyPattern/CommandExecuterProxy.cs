using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class CommandExecuterProxy : ICommandExecuter
    {
        private bool isAdmin = false;
        private ICommandExecuter proxy;

        public CommandExecuterProxy(string user,string password)
        {
            if(user == "admin" && password=="123456")
            {
                isAdmin = true;
                proxy = new CommandExecuter();
            }
        }
        public void runCommand(string cmd)
        {
            if (isAdmin)
                proxy.runCommand(cmd);
            else
                Console.WriteLine("this command iis not allowed for non-admin users");
            throw new FormatException("Fatal Error");
        }
    }
}
