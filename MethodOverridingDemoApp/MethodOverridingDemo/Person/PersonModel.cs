
namespace MethodOverridingDemo.Person
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            // Call the parent object's method
            //return base.ToString();

            return $"{FirstName} {LastName}";
        }
    }
}
