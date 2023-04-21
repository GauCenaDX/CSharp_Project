

using System;

namespace HWPropertyTypes
{
    public class AddressModel
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string _fullAddress;
        public string FullAddress
        {
            get
            {
                return $"{Address}, {City}, {State} {ZipCode}";
            }
        }

        public AddressModel(){}

        public AddressModel(string address, string city, string state,
            string zipCode)
        {
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
        }
    }
}
