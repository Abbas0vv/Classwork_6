using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLesson.Cars
{
    public class Car //Parent or Base class
    {
        protected int _currentSpeed;


        public Car(string color, int maxSpeed, int releaseDate, int speedBox, float engineValume)
        {
            Color = color;
            MaxSpeed = maxSpeed;
            ReleaseDate = releaseDate;
            SpeedBox = speedBox;
            EngineValume = engineValume;
        }

        public string Color { get; set; }

        public int MaxSpeed { get; set; }
        public int ReleaseDate { get; set; }
        public int SpeedBox { get; set; }  // 1 - Avtoma, 2 - Mexanika, 3 - Robot  
        public float EngineValume { get; set; }
        public bool IsSystemLocked { get; set; }


        public virtual void IncreaseSpeed()
        {
            _currentSpeed += 1;
        }
        public virtual void DecreaseSpeed()
        {
            _currentSpeed -= 1;
        }
        public virtual string GetDashbaordInfo()
        {
            return $"Speed : {_currentSpeed}";
        }
    }
}
