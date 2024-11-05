using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Sample2
{
    public class FactoryMobilApp
    {
        public static ICreatorMobileApp CreateMobilApp(string type)
        {
            if (type == "windows")
                return new WindowsApp();
            else if (type == "android")
                return new AndroidApp();
            else if (type == "ios")
                return new IOSApp();
            else
                return null;
        }
    }
}
