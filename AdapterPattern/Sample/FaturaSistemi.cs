using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Sample
{
    public class FaturaSistemi
    {
        private readonly ITarget calisanlar;

        public FaturaSistemi(ITarget _calisanlar)
        {
            this.calisanlar = _calisanlar;
        }

        public void CalisanlariGoster()
        {
            List<string> personeller = calisanlar.GetEmployeeList();
            Console.WriteLine("******* Çalışanlar Listesi *******");
            foreach (var item in personeller)
            {
                Console.WriteLine(item);
            }
        }
    }
}
