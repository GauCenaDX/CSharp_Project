
namespace HWInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a vehicle class, a car class, a boat class, and a
            // motorcycle class. Identify what inheritance should happen, if
            // any, and wire it up.


            Console.WriteLine("End of Program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }

    // A Vehicle is a machine that transports people or cargo
    public class Vehicle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
    }

    // A Car is a Vehicle
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }

        public void StartCar()
        {

        }

        public void StopCar()
        {

        }
    }

    // A Boat is a Vehicle (Based on DMV's definition)
    public class Boat : Vehicle
    {
        public int NumberOfMotor { get; set; }

        public void StartEngine()
        {

        }
    }

    // Motorcycle is a Vehicle
    public class Motorcycle : Vehicle
    {
        public string bikeTypes { get; set; }

        public void RetractKickstand()
        {

        }
    }
}
