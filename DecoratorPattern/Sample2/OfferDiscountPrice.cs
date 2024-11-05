using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample2
{
    public class OfferDiscountPrice : CarBaseDecorator
    {

        private CarBase carbase;

        public OfferDiscountPrice(CarBase _carbase):base(_carbase)
        {
            carbase = _carbase;
        }

        public decimal DiscountRate {  get; set; }
        public override decimal ListPrice 
        { 
            get => carbase.ListPrice * ((1-(DiscountRate/100)));
            set {  } 
        }
    }
}
