using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public int Year { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public abstract void DriveAbstract(); //stubbed out method 

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
    }
}
