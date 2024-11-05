using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MSSQLConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("MSSQL --> Close Connection");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("MSSQL --> Open Connection");
            return true;
        }
    }
}
