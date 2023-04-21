

using HWPropertyTypes;

AddressModel addressOne = new AddressModel();
AddressModel addressTwo = new AddressModel("8888 Golden Road", "Leaf Village",
    "IU", "91100");

addressOne.Address = "1249 My Street";
addressOne.City = "Mordor";
addressOne.State = "KFC";
addressOne.ZipCode = "12345";

Console.WriteLine($"{addressOne.Address}, {addressOne.City}, " +
    $"{addressOne.State} {addressOne.ZipCode}");

Console.WriteLine();
Console.WriteLine(addressTwo.FullAddress);

Console.WriteLine();
Console.WriteLine("End of program.");
