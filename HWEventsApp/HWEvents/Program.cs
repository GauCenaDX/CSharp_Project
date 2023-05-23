
namespace HWEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            BatteryModel battery = new BatteryModel();

            battery.BatteryIsLow += Battery_BatteryIsLow;

            while (battery.BatteryLevel > 0)
            {
                battery.CheckBatteryLevel();
                battery.DrainBatteryLevel(1);
            }

            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }

        private static void Battery_BatteryIsLow(object sender, string e)
        {
            Console.WriteLine();
            Console.WriteLine(e);
            Console.WriteLine();
        }
    }
}
