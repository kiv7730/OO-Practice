using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Truck : Vehicle
    {
        public Truck() { }
       
        public Truck(string name, Engine engine) : base(name, engine)
        {

        }

        public Truck(string name, double speed) : base(name, speed)
        {
        }
    }
}
