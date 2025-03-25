using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Carbuilder : Icarbuilder
    {
        private  Car car=new Car();
        public Icarbuilder SetEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }
        public Icarbuilder SetSeats(int seats)
        {
            car.Seats = seats;
            return this;
        }
        public Icarbuilder AddGPS()
        {
            car.has_gps = true;
            return this;
        }
        public Icarbuilder AddAirbags()
        {
            car.Has_airbags = true;
            return this;
        }
        public Car Build()
        {
            return car;
        }
    }
    
}
