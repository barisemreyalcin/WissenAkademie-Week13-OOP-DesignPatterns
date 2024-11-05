using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample1
{
    public class CreatorGamePC : CreatorComputer
    {
        private string ram;
        private string memory;
        private string hdd;
        private string cpu;

        public CreatorGamePC(string ram, string memory, string hdd, string cpu)
        {
            this.ram = ram;
            this.memory = memory;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string getCPU()
        {
            return cpu;
        }

        public override string getHDD()
        {
            return hdd;
        }

        public override string getMemory()
        {
            return memory;
        }

        public override string getRam()
        {
            return ram;
        }
    }
}
