using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Vehicle_factory_creator
    {
        public static Ivehiclefactory Getvehicleactory(string vehicletype)
        {
            switch (vehicletype.ToLower())
            {
                case "bike":
                    return new Bikefactory();
                case "car":
                    return new Carfactory();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }
}

