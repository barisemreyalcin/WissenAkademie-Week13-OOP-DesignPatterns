using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample2
{
    public class IOSApp : ICreatorMobileApp
    {
        public void Platform()
        {
            Console.WriteLine("Bu uygulama IOS Mobil için Çalışmaktadır");
        }
    }
}
