using Zaliczenie.Interfaces;

namespace Zaliczenie.Models
{
    public class Product : IProduct
    {
        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public float Price { get; set; }

        public virtual void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN");
        }
    }
}