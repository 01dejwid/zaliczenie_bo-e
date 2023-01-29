namespace Zaliczenie.Models
{
    public class DrinkProduct : Product
    {
        public DrinkProduct(string name, float price, DateTime expirationDate) : base(name, price)
        {
            Name = name;
            Price = price;
            ExpirationDate = expirationDate;
        }

        public DateTime ExpirationDate { get; }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN, Expiration date: {ExpirationDate}");
        }
    }
}