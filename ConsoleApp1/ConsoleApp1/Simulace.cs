using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Simulace
    {
        public delegate void OnEventThatCurrentTimeIsEven(string msg);
        public event OnEventThatCurrentTimeIsEven Lista;

        public int CurrentTime { get; set; }

        public Simulace()
        {
            CurrentTime = 0;
        }

        public void simulate()
        {
            while(CurrentTime < 10)
            {
                if ((CurrentTime % 2) == 0)  
                {
                    Console.WriteLine(CurrentTime);
                    Lista("TII");
                    //raiseEventCurrentTimeIsEven("Current Time is Even ");
                }
                System.Threading.Thread.Sleep(100);
                CurrentTime++;
            }
        }

        //public void raiseEventCurrentTimeIsEven(string msg)
        //{
        //    lista?.Invoke(msg);
        //}
    }
}
 