namespace Zaliczenie.Interfaces
{
    public interface ICategory
    {
        public IProduct GetProductFromAtIndex(Index index);

        void DisplayProducts();
    }
}