using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLesson.Cars
{
    //child class
    class Audi : Car
    {
        public Audi(string color, int maxSpeed, int releaseDate, int speedBox, float engineValume)
            : base(color, maxSpeed, releaseDate, speedBox, engineValume) { }

        //Dynamic polymorhism
        public override void IncreaseSpeed()
        {
            base.IncreaseSpeed();

            if (_currentSpeed == 40)
            {
                IsSystemLocked = true;
            }
        }
    }
}
