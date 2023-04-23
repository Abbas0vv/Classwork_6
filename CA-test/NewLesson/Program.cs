using NewLesson.Cars;
using NewLesson.Constants;

namespace NewLesson
{
    public class Database
    {
        public static List<Car> _cars = new List<Car>
            {
                new Bmw(Color.Blue, 240, 2018, SpeedBoxType.AUTO, 2.4f),
                new Audi(Color.Black, 400, 2020, SpeedBoxType.AUTO, 3.2f),
                new Mercedes(Color.Orange, 320, 1995, SpeedBoxType.MECHANIC, 3.8f),
                new Mercedes(Color.Blue, 250, 1990, SpeedBoxType.ROBOT, 2)
            };
    }

    public class Program
    {
        static void Main(string[] args)
        {
            foreach (Car car in Database._cars)
            {
                //float number = 23.5f;
                //int seconNumber = (int)number; // impliclity/explicity conversion oeprator

                int number = 23;

                decimal amount = number; //implicitly conversion operator

                if (car is Mercedes)
                {
                    //Explicitly casting (downcasting) (refencial casting)
                    Mercedes mercedes = (Mercedes)car;
                    Console.WriteLine(mercedes.IsRecommendedSpeed());
                }
            }
        }
    }
}