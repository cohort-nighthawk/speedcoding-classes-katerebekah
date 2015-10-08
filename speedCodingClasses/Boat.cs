using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Boat : Vehicle
    {
        public int NumberofWheels { get { return 0; } }

        public string Honk()
        {
            return "HONK!";
        }
    }
}
