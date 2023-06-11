using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        // Create a full property (read-only) using Lambda
        public string AddressDisplayValue => $"{StreetAddress}, {City}, {State} {ZipCode}";

        //public string FullAddressView
        //{
        //    get { return $"{StreetAddress}, {City}, {State} {ZipCode}"; }
        //}
    }
}
