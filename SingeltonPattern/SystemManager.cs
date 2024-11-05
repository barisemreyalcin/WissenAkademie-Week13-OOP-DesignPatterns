using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    public class SystemManager
    {
        private static SystemManager systemManager;

        private SystemManager() { }//Bu constructor dışarıdan erişilerrek instance alınmasını engelliyor

        public static SystemManager GetSystemManager() 
        {
            if(systemManager == null)
            {
                systemManager = new SystemManager();
            }
            return systemManager;
        }

        public void CreateLog()
        {
            Console.WriteLine("Write Sample Log");
        }
    }
}
