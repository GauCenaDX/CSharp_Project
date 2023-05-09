
namespace InterfaceDemo
{
    // Interface is a contract with standard requirements
    // Classes implement interfaces

    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();

            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BatteryPoweredGameController batteryGC = new BatteryPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {
                    controller.Connect();
                    controller.Connect();

                    gc.Dispose();
                }

                if (controller is IBatteryPowered powered)
                {
                    controller.Connect();
                    controller.CurrentKeyPressed();

                    powered.BatteryLevel = 5;
                }
            }

            // The using statement will call gc.Dispose at the end
            using (GameController gc = new GameController())
            {

            }


            List<IBatteryPowered> powereds = new List<IBatteryPowered>();
            powereds.Add(batteryGC);
            //powereds.Add(keyboard); //-- Not applicable
            powereds.Add(batteryKeyboard);

            Console.WriteLine("End of Program. Hit Enter to exit.");
            Console.ReadLine();
        }

        //public interface IComputerController : IDisposable
        public interface IComputerController
        {
            // Implied it is public
            void Connect();
            void CurrentKeyPressed();
        }

        public class Keyboard : IComputerController
        {
            public void Connect()
            {

            }

            public void CurrentKeyPressed()
            {

            }

            //public void Dispose()
            //{

            //}

            public string ConnectionType { get; set; }
        }

        public interface IBatteryPowered
        {
            int BatteryLevel { get; set; }
        }

        public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
        {
            public int BatteryLevel { get; set; }
        }

        public class GameController : IComputerController, IDisposable
        {
            public void Connect()
            {

            }

            public void CurrentKeyPressed()
            {

            }

            public void Dispose()
            {
                // do whatever shutdown tasks needed
            }
        }

        public class BatteryPoweredGameController : GameController, IBatteryPowered
        {
            public int BatteryLevel { get; set; }
        }
    }
}
