

using System;

namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { private get; set; }
        public string LastName { get; private set; }
        //public int Age { get; set; }

        public int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age need " +
                        "to be in a valid range.");
                }
            }
        }

        // Social Security Number 123-45-6789
        public string _ssn;
        public string SSN
        {
            get
            {
                // 123-45-6789 => index: 11 - 4 = 7
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }

            set
            {
                _ssn = value;
            }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string _password;
        public string Password
        {
            set { _password = value; }
        }

        // Constructor
        public PersonModel()
        {

        }

        // Constructor overloading
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
