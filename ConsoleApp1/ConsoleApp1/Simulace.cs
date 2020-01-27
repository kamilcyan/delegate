using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Simulace
    {
        public int CurrentTime;

        public Simulace()
        {
            CurrentTime = 0;
        }

        public void simulate()
        {
            while(CurrentTime < 10)
            {
                Console.WriteLine(CurrentTime);
                CurrentTime++;
            }
        }
    }
}
