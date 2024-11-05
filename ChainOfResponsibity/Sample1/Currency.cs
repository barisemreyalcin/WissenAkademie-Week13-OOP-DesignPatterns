using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibity.Sample1
{
    public class Currency
    {
        private int amount;

        public Currency(int _amount)
        {
            this.amount = _amount;
        }

        public int getAmount()
        {
            return this.amount;
        }
    }
}
