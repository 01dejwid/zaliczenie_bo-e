using Zaliczenie.Extensions;
using Zaliczenie.Models.Categories;

namespace Zaliczenie
{
    public class Stock
    {
        private static readonly Lazy<Stock> Instance = new Lazy<Stock>(() => new Stock());

        private Stock()
        {
            this.MockStock();
        }

        public static Stock GetInstance()
        {
            return Instance.Value;
        }

        public ElectronicCategory Electronics { get; set; }
        public FoodCategory Food { get; set; }
    }
}