using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    //Builder Interface
    public interface Icarbuilder
    {
        Icarbuilder SetEngine(string engine);
        Icarbuilder SetSeats(int seats);
        Icarbuilder AddGPS();
        Icarbuilder AddAirbags();

        Car Build();

    }
}
