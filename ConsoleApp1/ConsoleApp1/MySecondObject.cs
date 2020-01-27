using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MySecondObject
    {
        public void print(string msg)
        {
            Console.WriteLine(msg + "Object one");
        }

        public MySecondObject(Simulace simulace)
        {
            simulace.Lista += print;
        }
    }
}
