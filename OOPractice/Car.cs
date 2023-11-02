using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car() { }


        public Car(string name, Engine engine) : base(name, engine)
        {
        }

        public Car(string name, double speed) : base(name, speed)
        {
        }
    }
}
