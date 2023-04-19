

using System;

namespace HWInstantiatedClasses
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public AddressModel Address { get; set; }
    }
}