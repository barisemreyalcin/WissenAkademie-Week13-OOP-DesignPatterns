using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample2
{
    public class WindowsApp : ICreatorMobileApp
    {
        public void Platform()
        {
            Console.WriteLine("Bu uygulama Windows Mobil için Çalışmaktadır");
        }
    }
}
