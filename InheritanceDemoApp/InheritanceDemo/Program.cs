
namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Camry camry = new Camry();
            Corolla corolla = new Corolla();

            camry.StartCar();
            corolla.StopCar();


            List<Phone> phones = new List<Phone>();

            phones.Add(new Cellphone());
            phones.Add(new Smartphone());

            foreach (var phone in phones)
            {
                if (phone is Cellphone cellphone)
                {
                    cellphone.Carrier = "T-mobile";
                }

                if (phone is Smartphone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }

            Console.ReadLine();
        }
    }
}

