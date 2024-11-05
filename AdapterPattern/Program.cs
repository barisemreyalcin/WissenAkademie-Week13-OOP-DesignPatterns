// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Adapter tasarım deseninin gerçek hayattaki örneklerinden biri mobil şarj cihazları.Mobil pilin şarj olması 3 volata ihtiyacı vardır. Normal prizlerde 120 ya da 220 volt elektrik üretir. Bir şarj adaptörü yardımı ile 3 volt elektirik alacak şekilde işlemi gerçekleştirebiliyor.
 * 
 */

using AdapterPattern;
using AdapterPattern.Sample;

//MessageBoxAdapter adapter = new MessageBoxAdapter();
//adapter.MessageDilog("C# Design Patterns", "Adapter Design Pattern", Buttons.YesNo);


ITarget target = new CalisanAdapter();
FaturaSistemi fatura = new FaturaSistemi(target);
fatura.CalisanlariGoster();


