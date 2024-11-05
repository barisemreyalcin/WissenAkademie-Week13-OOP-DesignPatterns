using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample1
{
    public class FactoryCreator
    {
        public static CreatorComputer FactoryComputer(string type,string ram,string memory,string hdd, string cpu)
        {
            if (type == "gamePC")
            {
                return new CreatorGamePC(ram, memory, hdd, cpu);
            }
            else if (type == "developerPC")
            {
                return new CreatorDeveloperPC(ram, memory, hdd, cpu);
            }
            else
                return null;
        }
    }
}
