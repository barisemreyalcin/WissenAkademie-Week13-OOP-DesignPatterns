using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample2
{
    public class CarSuv : CarBase
    {
        public override decimal ListPrice { get ; set ; }
    }
}
