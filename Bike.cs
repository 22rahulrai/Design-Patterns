using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    //concrete product-Bike
    internal class Bike : Ivehicle
    {
        public int Numberofwheels() => 2;
        public string Vehicletype() => "Bike";
        
    }
}
