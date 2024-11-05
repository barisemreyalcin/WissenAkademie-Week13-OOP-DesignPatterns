using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibity.Sample1
{
    public class TL200WithDraw : IWithDrawChain
    {
        private IWithDrawChain chain;
        public void setNextChain(IWithDrawChain nextChain)
        {
            chain = nextChain;
        }

        public void withDraw(Currency currency)
        {
            int remainder = currency.getAmount() % 200;
            if (currency.getAmount() >= 200)
            {
                int num = currency.getAmount() / 200;
                Console.WriteLine($"{num} adet 200 TL verildi");
            }

            if (remainder != 0)
                chain.withDraw(new Currency(remainder));
        }
    }
}
