using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Vehiclefactory
    {
        public static Ivehicle Getvehicle(string objtype)
        {
            switch (objtype.ToLower())
            {
                case "bike":
                    return new Bike();
                case "car":
                    return new Car();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }
}
