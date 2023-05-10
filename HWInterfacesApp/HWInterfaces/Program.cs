namespace HWInterfaces
{
    // Create an IRun interface and apply it to a Person class and an Animal class.
    // Store both types in a List<IRun> object.

    class Program
    {
        static void Main(string[] args)
        {
            List<IRun> runners = new List<IRun>();
            Person person = new Person();
            Animal animal = new Animal();

            runners.Add(person);
            runners.Add(animal);

            foreach (IRun runner in runners)
            {
                runner.Distance = 15;
                runner.MaxSpeed = 3;
                runner.StartRunning();

                if (runner is Person human)
                {
                    human.SingWhileRunning();
                }

                if (runner is Animal humanHunter)
                {
                    humanHunter.SwitchToHuntingMode();
                    humanHunter.SpeedUp();
                }
            }


            Console.WriteLine("End of Program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}


