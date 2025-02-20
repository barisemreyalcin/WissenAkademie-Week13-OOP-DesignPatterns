﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonPattern.LazySingleton
{
    public class LazySingleton
    {
        private static LazySingleton instance;

        private LazySingleton()
        {

        }

        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new LazySingleton();
            }
            return instance;
        }
    }
}

