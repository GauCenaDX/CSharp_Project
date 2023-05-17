namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string coolQuote = "The future belongs to those who believe in the beauty of their dreams.";
            coolQuote.PrintToConsole();


            HotelRoomModel room101 = new HotelRoomModel();

            // Time to sleep
            room101.TurnOnAir().SetTemperature(72).CloseShades();

            // Wake up and go to work
            room101.TurnOffAir().OpenShades();

            Console.WriteLine();
            Console.WriteLine("End of Program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool IsShadesOpen { get; set; }
    }


    public static class ExtensionSamples
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.IsShadesOpen = true;
            return room;
        }

        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.IsShadesOpen = false;
            return room;
        }
    }
}
