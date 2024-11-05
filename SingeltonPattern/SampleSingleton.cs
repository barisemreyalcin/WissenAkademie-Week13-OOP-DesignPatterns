using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern
{
    public class SampleSingleton
    {
        private static SampleSingleton instance;

        private string data;
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        private SampleSingleton() { }

        public static SampleSingleton GetInstance()
        {
            if(instance == null)
            {
                instance = new SampleSingleton();
            }

            return instance;
        }
    }
}
