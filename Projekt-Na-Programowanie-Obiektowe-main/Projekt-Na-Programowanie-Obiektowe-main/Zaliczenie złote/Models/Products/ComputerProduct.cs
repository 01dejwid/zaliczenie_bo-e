using Zaliczenie.Enums;

namespace Zaliczenie.Models.Products
{
    public class ComputerProduct : Product
    {
        public ComputerProduct(string name, float price, ComputerType computerType) : base(name, price)
        {
            Name = name;
            Price = price;
            ComputerType = computerType;
        }

        public ComputerType ComputerType { get; }

        public override void DisplayProduct(int number)
        {
            Console.WriteLine($"{number}. {Name}, Price: {Price}PLN, Computer type: {ComputerType}");
        }
    }
}