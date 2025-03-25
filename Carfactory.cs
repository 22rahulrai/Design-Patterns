using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    // Concrete factory - car factory
    class Carfactory : Ivehiclefactory
    {
        public Ivehicle Createvehicle() => new Car();
    }
}
