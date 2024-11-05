using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample2
{
    public class AndroidApp : ICreatorMobileApp
    {
        public void Platform()
        {
            Console.WriteLine("Bu uygulama Android Mobil İçin Çalışmaktadır....");
        }
    }
}
