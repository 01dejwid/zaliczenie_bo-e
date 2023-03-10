using Zaliczenie.Enums;

namespace Zaliczenie.Models.Products
{
    public class MeatProduct : Product
    {
        public MeatProduct(string name, float price, MeatType meatType) : base(name, price)
        {
            Name = name;
            Price = price;
            MeatType = meatType;
        }

        public DateTime ExpirationDate { get; }

        public MeatType MeatType { get; }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN, Expiration date: {ExpirationDate}, Meat type: {MeatType}");
        }
    }
}