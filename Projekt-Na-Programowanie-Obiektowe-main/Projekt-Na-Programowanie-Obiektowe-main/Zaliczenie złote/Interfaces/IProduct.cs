namespace Zaliczenie.Interfaces
{
    public interface IProduct
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public void DisplayProduct(int number);
    }
}