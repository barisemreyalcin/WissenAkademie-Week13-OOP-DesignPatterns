using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern.MultiThreadSingleton
{
    public class MultiThreadSingleton
    {
        private static MultiThreadSingleton instance;
        private static readonly object lockObj = new object();

        private MultiThreadSingleton() { }

        public static MultiThreadSingleton GetInstance()
        {
            lock(lockObj)
            {
                if(instance == null)
                {
                    instance = new MultiThreadSingleton();
                }
            }
            return instance;
        }
    }
}
