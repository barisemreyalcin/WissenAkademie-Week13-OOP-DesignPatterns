using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibity.Sample1
{
    public interface IWithDrawChain
    {
        void setNextChain(IWithDrawChain nextChain);

        void withDraw(Currency currency);
    }
}
