using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    public class Car
    {
        public string Engine { get; set; }
        public int Seats { get; set; }
        public bool has_gps { get; set; }
        public bool Has_airbags { get; set;  }

        public void specification()
        {
            Console.WriteLine( $"Car Specification: \nEngine: {Engine}, Seats: {Seats}, has_gps: {has_gps}, Has_airbags: {Has_airbags}");
        }

    }

}
