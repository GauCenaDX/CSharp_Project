namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Eren", "Yeager");

            person.GenerateEmail();
            Console.WriteLine(person.Email);

            person.GenerateEmail(true);
            Console.WriteLine(person.Email);

            person.GenerateEmail("attackontitan",false);
            Console.WriteLine(person.Email);


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            //Email = $"{FirstName}.{LastName}@aol.com";

            // DRY
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail(string domain)
        {
            //Email = $"{FirstName}.{LastName}@{domain}";

            // DRY
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            //if (firstInitialMethod == true)
            //{
            //    Email = $"{FirstName.Substring(0, 1)}{LastName}@aol.com";
            //}
            //else
            //{
            //    Email = $"{FirstName}.{LastName}@aol.com";
            //}

            // DRY
            GenerateEmail("aol.com", firstInitialMethod);
        }

        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod == true)
            {
                Email = $"{FirstName.Substring(0, 1)}{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{domain}";
            }
        }
    }
}
