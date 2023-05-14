
namespace MethodOverridingDemo.Car
{
    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Just think about your destination");
        }

        public override void SetClock()
        {
            Console.WriteLine("It sets itself");
        }
    }
}
