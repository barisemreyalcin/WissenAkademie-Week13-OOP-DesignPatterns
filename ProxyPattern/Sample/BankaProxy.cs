using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Sample
{
    public class BankaProxy : IBanka
    {
        Banka banka;
        bool login;
        string userName, password;

        public BankaProxy(string _userName,string _password)
        {
            userName = _userName;
            password = _password;
        }

        bool GirisYap()
        {
            if(userName == "yonetici" && password.Equals("1234"))
            {
                login = true;
                banka = new Banka();
                Console.WriteLine("Giriş Başarılı");
                return true;
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
                login = false;
                return false;
            }
        }
        public bool OdemeYap(double tutar)
        {
            GirisYap();

            if(!login)
            {
                Console.WriteLine("Hesaba giriş yapılamadığı için ödeme gerçekleştirilememiştir...");
                return false;
            }

            banka.Pay(tutar);
            return true;
        }
    }
}
