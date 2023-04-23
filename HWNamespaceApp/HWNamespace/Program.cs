

// - Create a class file
// - Change the namespace
// - Call a method in that class

using TestModels;

HouseModel houseA = new HouseModel();

houseA.NumberOfBedRooms = 4;
houseA.NumberOfBathRooms = 2;
houseA.GarageType = "Double";

Console.WriteLine("This is our current house model:");
Console.WriteLine($"  . Number of bedrooms: {houseA.NumberOfBedRooms}");
Console.WriteLine($"  . Number of athrooms: {houseA.NumberOfBathRooms}");
Console.WriteLine($"  . Garage type: {houseA.GarageType}");

Console.WriteLine();
Console.WriteLine("End of program.");
