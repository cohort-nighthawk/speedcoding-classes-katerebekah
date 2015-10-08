using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Truck : Vehicle
    {
        public int NumberofWheels { get { return 4; } }

        public string Honk()
        {
            return "HONK!";
        }
    }
}
