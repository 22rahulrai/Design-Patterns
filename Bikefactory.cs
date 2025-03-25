using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    // Concrete factory - Bike factory
    class Bikefactory:Ivehiclefactory
    {
        public Ivehicle Createvehicle() => new Bike();
    }
}
