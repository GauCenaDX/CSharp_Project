
namespace SaveListToFile
{
    public class PersonModel
    {
        // Note: the properties can be any type of data. Because we can use
        // ToString() to represent their values as string and save them to a file.

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
