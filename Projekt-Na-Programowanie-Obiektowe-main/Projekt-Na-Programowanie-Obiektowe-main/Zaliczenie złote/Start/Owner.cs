using Zaliczenie.Models;

namespace Zaliczenie.Start
{
    public class Owner
    {
        public int Run()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to your store! What would you like to do?");
                Console.WriteLine("1. Edit assortment.");
                Console.WriteLine("2. Check your bills");
                Console.WriteLine("3. Exit the store.");
                Console.WriteLine("9. Change role to shop customer");
                var userChoice = Console.ReadKey();
                Console.WriteLine();
                switch (userChoice.KeyChar)
                {
                    case '1':
                        EditStock();
                        break;

                    case '2':
                        SearchRecepies();
                        break;

                    case '3':
                        Environment.Exit(0);
                        break;

                    case '9':
                        Customer clientContext = new();
                        clientContext.Run();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Wrong selection. Try again.");
                        break;
                }
            }
            return 0;
        }

        private void SearchRecepies()
        {
            var directoryPath = System.IO.Directory.GetCurrentDirectory();
            var savePath = Path.Combine(directoryPath, "Receipt");
            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            var files = Directory.GetFiles(savePath);

            Console.WriteLine();
            Console.WriteLine("Saved bills:  ");
            foreach (var file in files)
            {
                var name = Path.GetFileName(file);
                var date = File.GetCreationTimeUtc(file);
                Console.WriteLine($"Bill: {name} created {date}");
            }
        }

        private void EditStock()
        {
            var stock = Items.GetInstance();

            Console.WriteLine("Electronics products");
            stock.Electronics.DisplayProducts();
            Console.WriteLine();
            Console.WriteLine("Food category products");
            stock.Food.DisplayProducts();
            Console.WriteLine();
            Console.WriteLine("What you want to do?");
            Console.WriteLine("0. Undo.");
            Console.WriteLine("1. Add a product.");
            Console.WriteLine("2. Remove the product.");
            var userChoice = Console.ReadKey();
            Console.WriteLine();
            switch (userChoice.KeyChar)
            {
                case '0':
                    return;

                case '1':
                    Console.WriteLine("Which category to add? (0 - Food, 1 - Electronics)");
                    int choice = UserAction.Get0or1();
                    if (choice == 0)
                        AddFood();
                    else
                        AddElectronic();
                    break;

                case '2':
                    Console.WriteLine("Which category to remove? (0 - Food, 1 - Electronics)");
                    int choice2 = UserAction.Get0or1();
                    if (choice2 == 0)
                        RemoveFood();
                    else
                        RemoveElectronic();
                    break;

                default:
                    Console.WriteLine("Wrong selection. Try again.");
                    break;
            }
        }

        private void AddFood()
        {
            var stock = Items.GetInstance();
            Console.WriteLine("Enter the name of the product");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the price of the product");
            var price = Console.ReadLine();

            if (float.TryParse(price, out float result))
            {
                Product product = new(name, result);
                stock.Food.Products.Add(product);
            }
            else
            {
                Console.WriteLine("Wrong price");
            }
        }

        private void AddElectronic()
        {
            var stock = Items.GetInstance();
            Console.WriteLine("Enter the name of the product");
            var name = Console.ReadLine();

            Console.WriteLine("Enter the price of the product");
            var price = Console.ReadLine();

            if (float.TryParse(price, out float result))
            {
                Product product = new(name, result);
                stock.Electronics.Products.Add(product);
            }
            else
            {
                Console.WriteLine("Wrong price");
            }
        }

        private void RemoveFood()
        {
            var stock = Items.GetInstance();
            stock.Food.DisplayProducts();
            Console.WriteLine("Which product do you want to remove? (0 - exit)");
            var productNum = Console.ReadLine();
            if (int.TryParse(productNum, out int productIndex))
            {
                if (productIndex == 0)
                    return;
                if (productIndex > 0)
                {
                    if (stock.Food.RemoveProductAtIndex(productIndex - 1))
                    {
                        Console.WriteLine("The product has been removed");
                    }
                    else
                    {
                        Console.WriteLine("There is no such product");
                    }
                }
                else
                {
                    Console.WriteLine("There is no such product");
                }
            }
            else
            {
                Console.WriteLine("Wrong product");
            }
        }

        private void RemoveElectronic()
        {
            var stock = Items.GetInstance();
            stock.Electronics.DisplayProducts();
            Console.WriteLine("Which product do you want to remove? (0 - exit)");
            var productNum = Console.ReadLine();
            if (int.TryParse(productNum, out int productIndex))
            {
                if (productIndex == 0)
                    return;
                if (productIndex > 0)
                {
                    if (stock.Electronics.RemoveProductAtIndex(productIndex - 1))
                    {
                        Console.WriteLine("The product has been removed");
                    }
                    else
                    {
                        Console.WriteLine("There is no such product");
                    }
                }
                else
                {
                    Console.WriteLine("There is no such product");
                }
            }
            else
            {
                Console.WriteLine("Wrong product");
            }
        }
    }
}