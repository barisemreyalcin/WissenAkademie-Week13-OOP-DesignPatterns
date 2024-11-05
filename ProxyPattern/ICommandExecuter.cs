using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface ICommandExecuter
    {
        public void runCommand(string cmd);
    }
}
