using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CreditCardFacade
    {
        public void CreateCreditCard(Customer customer)
        {
            CreditCardManager manager = new CreditCardManager();
            BlackListService blackListService = new BlackListService();

            if (!blackListService.CheckCustomerIsBlackList(customer))
            {
                manager.CreateCreditCard(customer);
            }
        }
    }
}
