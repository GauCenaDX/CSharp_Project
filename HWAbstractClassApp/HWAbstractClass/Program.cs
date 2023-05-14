
namespace HWAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> actionFigures = new List<IProduct>();

            actionFigures.Add(new ActionFigure { ProductName = "Gut Berseker",
                ProductPrice = 199.99M, QuantityInStock = 5, ScaleRatio = "1:6" });
            actionFigures.Add(new ActionFigure { ProductName = "Monkey D Luffy",
                ProductPrice = 80M, QuantityInStock = 1, ScaleRatio = "1:10"});

            foreach (IProduct figure in actionFigures)
            {
                figure.addProduct(5);
                PrintProductInfo(figure);
            }


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }

        public static void PrintProductInfo(IProduct product)
        {
            Console.WriteLine();
            Console.WriteLine($"Product name: {product.ProductName}");
            Console.WriteLine($"Product price: ${product.ProductPrice}");
            Console.WriteLine($"Quantity in stock: {product.QuantityInStock}");

            if (product is ActionFigure actionFigure)
            {
                Console.WriteLine($"Scale ratio: {actionFigure.ScaleRatio}");
            }
        }
    }

    public interface IProduct
    {
        string ProductName { get; set; }
        decimal ProductPrice { get; set; }
        int QuantityInStock { get; set; }

        void removeProduct(int quantity);
        void addProduct(int quantity);
    }

    public abstract class InventoryItem : IProduct
    {
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int QuantityInStock { get; set; }

        public void addProduct(int quantity)
        {
            QuantityInStock += quantity;
        }

        public void removeProduct(int quantity)
        {
            QuantityInStock -= quantity;
        }
    }

    public class ActionFigure : InventoryItem
    {
        public string ScaleRatio { get; set; }
    }
}
