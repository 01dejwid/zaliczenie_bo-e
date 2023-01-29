namespace Zaliczenie.Models.Products
{
    public class HeadphoneProduct : Product
    {
        public HeadphoneProduct(string name, float price, bool hasCable) : base(name, price)
        {
            Name = name;
            Price = price;
            HasCable = hasCable;
        }

        public bool HasCable { get; }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN, Wire: {(HasCable ? "Yes" : "No")}");
        }
    }
}