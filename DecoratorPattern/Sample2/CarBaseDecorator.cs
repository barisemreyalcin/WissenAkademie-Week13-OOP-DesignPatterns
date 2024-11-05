using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample2
{
    public abstract class CarBaseDecorator : CarBase
    {
        private CarBase carBase;

        public CarBaseDecorator(CarBase _carBase)
        {
            this.carBase = _carBase;
        }
    }
}
