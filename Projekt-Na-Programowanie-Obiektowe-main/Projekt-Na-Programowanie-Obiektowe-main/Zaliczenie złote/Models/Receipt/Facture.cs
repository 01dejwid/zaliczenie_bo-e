using System.Text;

namespace Zaliczenie.Models.Receipt
{
    public class Facture : ReceiptBase
    {
        public override void CreateReceipt()
        {
            Console.WriteLine("Please enter your tax identification number");
        }

        private string CreateFacture(string nipNumber)
        {
            StringBuilder stringBuilder = new();
            return stringBuilder.ToString();
        }
    }
}