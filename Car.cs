﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    //Concrete Product- Car
    class Car : Ivehicle
    {
        public int Numberofwheels() => 4;
        public string Vehicletype() => "Car";
        
    }
}
