using System;

namespace ConsoleUI
{
    // Blueprint
    public class PersonModel
    {
        //// These variables don't work well with class instances.
        //// Especially with Data Binding and Reflection.
        //public string firstName;
        //public string lastName;
        //public string emailAddress;

        // An introduction to Properties - Auto property
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}
