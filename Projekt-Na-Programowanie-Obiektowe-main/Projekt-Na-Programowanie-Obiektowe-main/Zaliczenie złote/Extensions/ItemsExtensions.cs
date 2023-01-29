using Zaliczenie.Models;
using Zaliczenie.Models.Products;

namespace Zaliczenie.Extensions
{
    public static class ItemsExtensions
    {
        public static void MockStock(this Items stock)
        {
            stock.Electronics = new Models.Categories.ElectronicCategory()
            {
                Products = new List<Models.Product>
                {
                    new ComputerProduct("G4M3R HERO i5-12400F/16GB/1TB/RTX3060", 6000, Enums.ComputerType.PC),
                    new ComputerProduct("Lenovo Legion 5-15 Ryzen 7 5800H/16GB/512/Win11 RTX3060", 6099, Enums.ComputerType.Laptop),
                    new ComputerProduct("HP Victus 15 i5-12450H/16GB/512 RTX3050", 3699.99f, Enums.ComputerType.Laptop),
                    new HeadphoneProduct("Logitech G PRO X GAMING HEADSET", 500, false),
                    new HeadphoneProduct("SPC Gear VIRO Plus USB", 215, false),
                    new HeadphoneProduct("JBL Tune 510BT", 190, true)
                }
            };
            stock.Food = new Models.Categories.FoodCategory()
            {
                Products = new List<Models.Product>
                {
                    new DrinkProduct("Water", 3.20f, new DateTime(2024, 10, 11, 15, 0, 0, 0)),
                    new DrinkProduct("Tymbark", 5, new DateTime(2023, 12, 12, 15, 0, 0, 0)),
                    new DrinkProduct("Vodka", 3.20f, new DateTime(2023, 2, 20, 15, 0, 0, 0)),
                    new DrinkProduct("Wine", 3.20f, new DateTime(2023, 3, 11, 11, 0, 0, 0)),
                    new MeatProduct("Steak", 12, Enums.FoodType.Beef),
                    new MeatProduct("Rib", 15, Enums.FoodType.Pork),
                    new MeatProduct("Breast", 10, Enums.FoodType.Chicken),
                    new Vegeproducts("Vegan cheese", 15),
                    new Vegeproducts("Egg substitutes", 12.5f),
                    new Vegeproducts("Soy milk", 14.45f),
                    new Vegeproducts("Soy-based sausages", 25),
                }
            };
        }
    }
}