using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLesson.Cars
{
    class Mercedes : Car
    {
        public Mercedes(string color, int maxSpeed, int releaseDate, int speedBox, float engineVolume)
            : base(color, maxSpeed, releaseDate, speedBox, engineVolume) { }

        public bool IsRecommendedSpeed()
        {
            if (_currentSpeed >= 200)
            {
                return false;
            }

            return true;
        }

        public override string GetDashbaordInfo()
        {
            return $"Hey, racer you speed : {_currentSpeed}";
        }
    }
}
