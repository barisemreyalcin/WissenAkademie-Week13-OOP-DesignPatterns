// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ProxyPattern;
using ProxyPattern.Sample;

//ICommandExecuter exec = new CommandExecuterProxy("admin", "123456");
//try
//{
//    exec.runCommand("cls");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

string kullaniciAdi = string.Empty;
string parola = string.Empty;
double tutar = 0;

while(true)
{
    Console.Write("Kullanıcı Adı : ");
    kullaniciAdi = Console.ReadLine();

    Console.Write("Parola : ");
    parola = Console.ReadLine();

    Console.Write("Tutar : ");
    tutar = Convert.ToDouble(Console.ReadLine());

    IBanka banka = new BankaProxy(kullaniciAdi, parola);
    banka.OdemeYap(tutar);

    Console.WriteLine("*************************");
    Console.ReadLine();
}
