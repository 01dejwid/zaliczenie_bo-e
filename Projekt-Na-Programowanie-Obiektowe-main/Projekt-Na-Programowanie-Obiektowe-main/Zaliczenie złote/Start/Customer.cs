using Zaliczenie.Enums;

namespace Zaliczenie.Start

{
    public class Customer
    {
        public Customer()
        {
        }

        public int Run()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Hello customer! What would you like to do?");
                Console.WriteLine("1. Show assortment in category Electronics.");
                Console.WriteLine("2. Show assortment in category Food.");
                Console.WriteLine("3. Go to payment");
                Console.WriteLine("4. Edit your shopping list");
                Console.WriteLine("5. Exit the store");
                Console.WriteLine("9. Change the role to shop owner");
                var userChoice = Console.ReadKey();
                Console.WriteLine();
                switch (userChoice.KeyChar)
                {
                    case '1':
                        ShowElectronicMenu();
                        break;

                    case '2':
                        ShowFoodMenu();
                        break;

                    case '3':
                        GenerateReceipt();
                        return 0;

                    case '4':
                        ModifyOrder();
                        break;

                    case '5':
                        Environment.Exit(0);
                        return 1;

                    case '9':
                        Owner ownerContext = new();
                        ownerContext.Run();
                        break;

                    default:
                        Console.WriteLine("Wrong choose. Try again.");
                        break;
                }
            }
            return 0;
        }

        private void ShowElectronicMenu()
        {
            var stockInstance = Items.GetInstance();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Your current order");
                CustomerOrder.DisplayOrder();
                Console.WriteLine("Which product do you want to add? (0 - exit)");
                stockInstance.Electronics.DisplayProducts();
                var productNum = Console.ReadLine();
                if (int.TryParse(productNum, out int productIndex))
                {
                    if (productIndex == 0)
                        return;
                    if (productIndex > 0)
                    {
                        var product = stockInstance.Electronics.GetProductFromAtIndex(productIndex - 1);
                        if (product != null)
                        {
                            CustomerOrder.AddProduct(product);
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
            }
        }

        private void GenerateReceipt()
        {
            Console.WriteLine("Payment will be made on account or invoice. (0 - bill, 1 - invoice)");
            var userChoice = UserAction.Get0or1();
            ReceiptType receiptType = userChoice == 0 ? ReceiptType.Bill : ReceiptType.Facture;
            var receiptOfChoice = ReceiptFactory.GetReceiptImplementation(receiptType);
            receiptOfChoice.CreateReceipt();
        }

        private void ModifyOrder()
        {
            while (true)
            {
                Console.WriteLine("Your current order");
                CustomerOrder.DisplayOrder();
                Console.WriteLine("Which product do you want to remove? (0 - exit)");
                var productNum = Console.ReadLine();
                if (int.TryParse(productNum, out int productIndex))
                {
                    if (productIndex == 0)
                        return;
                    if (productIndex > 0)
                    {
                        if (CustomerOrder.TryRemoveProduct(productIndex - 1))
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
            }
        }

        private void ShowFoodMenu()
        {
            var stockInstance = Items.GetInstance();
            while (true)
            {
                Console.WriteLine("Your current order");
                CustomerOrder.DisplayOrder();
                Console.WriteLine();
                Console.WriteLine("Which product do you want to add? (0 - exit)");
                stockInstance.Food.DisplayProducts();
                var productNum = Console.ReadLine();
                if (int.TryParse(productNum, out int productIndex))
                {
                    if (productIndex == 0)
                        return;
                    var product = stockInstance.Food.GetProductFromAtIndex(productIndex - 1);
                    if (product != null)
                    {
                        CustomerOrder.AddProduct(product);
                    }
                }
            }
        }
    }
}