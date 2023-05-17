
namespace HWExtensionMethod
{
    // Create the following chain using extension methods:
    // person.SetDefaultAge().PrintInfo();

    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> animeCharacters = new List<PersonModel>();

            animeCharacters.Add(new PersonModel("Kyojuro Rengoku", CharacterOrigins.DemonSlayer));
            animeCharacters.Add(new PersonModel("Levi Ackerman", CharacterOrigins.AttackOnTitan));
            animeCharacters.Add(new PersonModel("Mokey D. Luffy", CharacterOrigins.OnePiece));
            animeCharacters.Add(new PersonModel("Satoru Gojo", CharacterOrigins.JujutsuKaisen));

            foreach (var person in animeCharacters)
            {
                person.SetDefaultAge().PrintInfo();
            }
            

            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public CharacterOrigins Origin { get; set; }

        public PersonModel(string fullName, CharacterOrigins origin)
        {
            FullName = fullName;
            Origin = origin;
            Age = 0;
        }
    }

    public enum CharacterOrigins
    {
        AttackOnTitan,
        OnePiece,
        JujutsuKaisen,
        DemonSlayer
    }

    public static class ExtensionMethods
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 27;
            return person;
        }

        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine();
            Console.WriteLine($"Name: {person.FullName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Origin: {person.Origin}");
        }
    }
}
