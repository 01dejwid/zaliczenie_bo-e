namespace Zaliczenie.Models.Products
{
    public class Vegeproducts : Product
    {
        public Vegeproducts(string name, float price) : base(name, price)
        {
            Name = name;
            Price = price;
        }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN");
        }
    }
}