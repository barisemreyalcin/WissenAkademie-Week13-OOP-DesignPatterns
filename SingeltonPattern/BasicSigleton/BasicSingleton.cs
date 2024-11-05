using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern.BasicSigleton
{
    public class BasicSingleton
    {
        /*
         * Eager initialization olarak adlandırılan bu yapı sınıfın örneğini sınıf yğklemesi sırasında oluşturur.
         */
        private static BasicSingleton instance;

        private BasicSingleton()
        {
            instance = new BasicSingleton();
        }

        public static BasicSingleton GetInstance()
        {
            return instance; 
        }
    }
}
