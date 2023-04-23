namespace NewLesson.Cars
{
    //Inheritance
    class Bmw : Car
    {
        public Bmw(string color, int maxSpeed, int releaseDate, int speedBox, float engineValume)
            : base(color, maxSpeed, releaseDate, speedBox, engineValume)
        {


        }

        //Dynamic polymorhism
        public override string GetDashbaordInfo()
        {
            if (_currentSpeed % 5 == 0)
                return base.GetDashbaordInfo();
            else
                return $"Speed : {_currentSpeed / 5 * 5}";
        }
    }
}
