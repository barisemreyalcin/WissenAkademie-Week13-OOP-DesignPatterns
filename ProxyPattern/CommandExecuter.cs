using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class CommandExecuter : ICommandExecuter
    {
        public void runCommand(string cmd)
        {
            Console.WriteLine($"{cmd} command executed");
        }
    }
}
