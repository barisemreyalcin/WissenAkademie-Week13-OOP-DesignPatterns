using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample1
{
    public abstract class CreatorComputer
    {
        public abstract string getRam();
        public abstract string getMemory();
        public abstract string getHDD();
        public abstract string getCPU();

        public override string ToString()
        {
            string str = $"RAM : {getRam()} , Memory : {getMemory()} , HDD : {getHDD()} , CPU : {getCPU()}";
            return str;
        }
    }
}
