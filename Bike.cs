using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Bike : Ivehicle
    {
        private readonly int wheels;

        public Bike(){
            this.wheels=2;
        }
        public int Numberofwheels()
        {
            return this.wheels;
        }

        public string Vehicletype()
        {
            return "Bike";
        }
    }
}
