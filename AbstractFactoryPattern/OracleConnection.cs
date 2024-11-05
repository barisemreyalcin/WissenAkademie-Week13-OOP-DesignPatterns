using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("Oracle --> Close Connection");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("Oracle --> Open Connection");
            return true;
        }
    }
}
