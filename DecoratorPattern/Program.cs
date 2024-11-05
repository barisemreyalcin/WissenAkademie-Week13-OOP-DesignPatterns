// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 * Sınıfın yapısın dadeğişikliğe gitmeden belirli bir nesneye veya bazı nesnelere yeni ek özellikler yad afonksiyonlar eklemek için kullanılır. Buradaki önemli ayrıntı yeni özelliğin sınıfa değil belirli bir nesneye kazandırılıyor olması. Bu şekilde sınıftan türetilen diğer nesneler bu ek özellik yada fonksiyondan etkilenmez
 * 
 * 
 */

using DecoratorPattern.Sample1;
using DecoratorPattern.Sample2;

//Window w1 = new LoginWindow("Sisteme Giriş Ekranı");
//Window w2 = new ReportWindow("Stok Raporu Ekranı");
//Window w3 = new ReportWindow("Satış Raporu Ekranı");

//ThemaDecorator decorator1 = new ThemaDecorator(w1, "Sisteme Giriş");
//ThemaDecorator decorator2 = new ThemaDecorator(w2, "Stok Raporu");
//ThemaDecorator decorator3 = new ThemaDecorator(w3, "Satış Raporu");


//decorator1.SetTheme("Ayder Yaylası");
//decorator2.SetTheme("Ürgüp Göreme");
//decorator3.SetTheme("Pamukakle");

CarBase car = new CarSuv()
{
    Brand="Dodge",
    Model = "2500 Pawer Wagon",
    ListPrice = 100000
};

OfferDiscountPrice offerDiscount = new OfferDiscountPrice(car);
offerDiscount.DiscountRate = 25;
Console.WriteLine($"Liste Fiyatı : {car.ListPrice}");
Console.WriteLine($"İndirimli Fiyat : {offerDiscount.ListPrice}");






