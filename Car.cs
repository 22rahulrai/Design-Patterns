using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Car : Ivehicle
    {
        private readonly int wheels;

        public Car()
        {
            this.wheels = 4;
        }
        public int Numberofwheels()
        {
            return this.wheels;
        }

        public string Vehicletype()
        {
            return "Car";
        }
    }
}
