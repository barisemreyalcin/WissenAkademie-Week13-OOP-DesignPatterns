using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MessageBoxAdapter
    {
        private MessageBoxAdapt adpt;

        public MessageBoxAdapter()
        {
            adpt = new MessageBoxAdapt();
        }

        public void MessageDilog(string title,string text,Buttons buttons)
        {
            adpt.alert(title, text, buttons);
        }
    }
}
