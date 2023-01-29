using System.Text;

namespace Zaliczenie.Models.Receipt
{
    public class Bill : ReceiptBase
    {
        public override void CreateReceipt()
        {
            var receipt = CreateBill();
            ShowReceipt(receipt);
            Console.WriteLine("Save the bill? (0 - no, 1 - yes");
            var userChoice = UserAction.Get0or1();
            if (userChoice == 1)
            {
                SaveReceipt(receipt);
            }
        }

        private string CreateBill()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine($"Bill of the day {DateTime.Now}.");            
            return stringBuilder.ToString();
        }
    }
}