using Zaliczenie.Extensions;
using Zaliczenie.Models.Categories;

namespace Zaliczenie
{
    public class Items
    {
        private static readonly Lazy<Items> Instance = new Lazy<Items>(() => new Items());

        private Items()
        {
            this.MockStock();
        }

        public static Items GetInstance()
        {
            return Instance.Value;
        }

        public ElectronicCategory Electronics { get; set; }
        public FoodCategory Food { get; set; }
    }
}