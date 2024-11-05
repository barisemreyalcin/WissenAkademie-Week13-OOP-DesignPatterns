// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Chain Of Responsibilty Desing Pattern(Sorumluluk zinciri modeli)
 * kullanıcdan gelen bir talebin işlenilmesi için bir nesneler zincirine iletildiği tasarım kalıbıdır.
 * 
 */

using ChainOfResponsibity.Sample1;

ATMWithDrawChain atm = new ATMWithDrawChain();
while(true)
{
    int amount = 0;
    Console.Write("Çekmek istediğiniz miktar : ");
    amount = int.Parse(Console.ReadLine());
    if(amount % 50 != 0)
    {
        Console.WriteLine("Tutar 50 nin katı olmalıdır...");
        return;
    }
    atm.c1.withDraw(new Currency(amount));
}