// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using FacadePattern;

Customer customer = new Customer("John", "Doe");
//CreditCardManager manager = new CreditCardManager();
//BlackListService blackListService = new BlackListService();

//if(!blackListService.CheckCustomerIsBlackList(customer))
//{
//    manager.CreateCreditCard(customer);
//}

CreditCardFacade facade = new CreditCardFacade();
facade.CreateCreditCard(customer);
