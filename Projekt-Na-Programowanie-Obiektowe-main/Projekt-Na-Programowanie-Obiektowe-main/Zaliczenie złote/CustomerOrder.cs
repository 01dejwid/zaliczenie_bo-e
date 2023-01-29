using Zaliczenie.Interfaces;
using Zaliczenie.Models;

namespace Zaliczenie
{
    public static class CustomerOrder
    {
        private static List<IProduct> Products;

        static CustomerOrder()
        {
            Products = new List<IProduct>();
        }

        public static int Count { get => Products.Count; }
        public static float FinalPrice { get => Products.Sum(x => x.Price); }

        public static bool TryRemoveProduct(Index index)
        {
            try
            {
                Products.RemoveAt(index.Value);
                return true;
            }
            catch (Exception x)
            {
                return false;
            }
        }

        public static void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public static void DisplayOrder()
        {
            int counter = 1;
            Console.WriteLine();
            foreach (var product in Products)
            {
                Console.WriteLine($"{counter}. {product.Name} {product.Price}");
                counter++;
            }
            Console.WriteLine($"Final price {FinalPrice}. {Count} items.");
            Console.WriteLine();
        }

        public static void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public static List<IProduct> GetProducts => Products;
    }
}