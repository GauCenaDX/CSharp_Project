using System.Collections.Generic;
using System;
using InheritanceMiniProject.Interfaces;
using InheritanceMiniProject.Models;

namespace InheritanceMiniProject
{
    // We will have an Inventory System.And we're going to ask the user to buy
    // things or rent things from us. The Inventory System has three Items:
    // Vehicle, Book and Excavator. We can rent excavators, purchase books, and
    // rent or purchase vehicle.

    class Program
    {
        static void Main(string[] args)
        {
            //List<InventoryItemModel> inventory = new List<InventoryItemModel>();

            //inventory.Add(new VehicleModel { DealerFee = 250, ProductName = "Kia Optima" });
            //inventory.Add(new BookModel { ProductName = "The Lord of the Rings", NumberOfPages = 500});


            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            var vehicle = new VehicleModel { DealerFee = 300, ProductName = "Toyota Rav 4" };
            var book = new BookModel { ProductName = "So Good They Can't Ignore You",
                NumberOfPages = 300 };
            var excavator = new ExcavatorModel { ProductName = "Bulldozer", QuantityInStock = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            Console.WriteLine("Do you want to rent or purchase something? (rent or purchase) ");
            string rentalDecision = Console.ReadLine();

            if (rentalDecision.ToLower() == "rent")
            {
                foreach (var item in rentables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine("Do you want to rent this item? (yes/no) ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        item.Rent();
                    }

                    Console.WriteLine("Do you want to return this item? (yes/no) ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        item.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (var item in purchasables)
                {
                    Console.WriteLine($"Item: {item.ProductName}");
                    Console.WriteLine("Do you want to purchase this item? (yes/no) ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        item.Purchase();
                    }
                }
            }


            Console.WriteLine("End of Program. Hit Enter to exit.");
            Console.ReadLine();
        }
    }
}
