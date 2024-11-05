using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Sample2
{
    public abstract class ProtypeGame
    {
        public abstract ProtypeGame Clone();
    }
}
