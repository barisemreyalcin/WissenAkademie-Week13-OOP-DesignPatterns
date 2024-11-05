using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Sample
{
    public class CalisanSistemi
    {
        public string[][] CalisanLariGetir()
        {
            string[][] calisanlar = new string[4][];
            calisanlar[0] = new string[] { "100", "John", "IT" };
            calisanlar[1] = new string[] { "101", "Jeyn", "IK" };
            calisanlar[2] = new string[] { "102", "Tom", "Marketing" };
            calisanlar[3] = new string[] { "103", "Poul", "Service" };

            return calisanlar;
        }




    }
}
