﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyObject
    {
        public void print(string msg)
        {
            Console.WriteLine(msg + "Object zero");
        }

        public MyObject(Simulace simulace)
        {
            simulace.Lista += print;
        }
    }
}
