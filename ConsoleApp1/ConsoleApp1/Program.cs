using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulace simulace = new Simulace();
            MyObject myObject = new MyObject(simulace);
            MySecondObject mySecondObject = new MySecondObject(simulace);

            simulace.simulate();

            Console.ReadKey();
        }
    }
}
