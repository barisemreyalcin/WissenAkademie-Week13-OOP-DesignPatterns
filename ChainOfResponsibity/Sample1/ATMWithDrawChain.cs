using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibity.Sample1
{
    public class ATMWithDrawChain
    {
        public IWithDrawChain c1;
        public ATMWithDrawChain()
        {
            c1 = new TL200WithDraw();
            IWithDrawChain c2 = new TL100WithDraw();
            IWithDrawChain c3 = new TL50WithDraw();

            c1.setNextChain(c2);
            c2.setNextChain(c3);
        }
        


    }
}
