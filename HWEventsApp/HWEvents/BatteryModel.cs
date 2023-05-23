
namespace HWEvents
{
    public class BatteryModel
    {
        public event EventHandler<string> BatteryIsLow;

        public int BatteryLevel { get; private set; } = 100;

        public void DrainBatteryLevel(int percentage)
        {
            BatteryLevel -= percentage;
        }

        public void CheckBatteryLevel()
        {
            Console.WriteLine($"Battery level is at {BatteryLevel}%");

            if (BatteryLevel < 25)
            {
                BatteryIsLow?.Invoke(this, $"WARNING: Battery is under 25%.");
            }

        }
    }
}
