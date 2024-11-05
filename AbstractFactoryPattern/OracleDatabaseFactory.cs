using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class OracleDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new OracleCommand();
        }

        public Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
