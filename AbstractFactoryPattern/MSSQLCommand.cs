using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MSSQLCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            Console.WriteLine($"SQL Server Quer : {query}");
        }
    }
}
