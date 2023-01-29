using Zaliczenie.Enums;
using Zaliczenie.Models.Receipt;

namespace Zaliczenie
{
    public static class ReceiptFactory
    {
        public static ReceiptBase GetReceiptImplementation(ReceiptType receiptType)
        {
            return receiptType switch
            {
                ReceiptType.Facture => new Facture(),
                ReceiptType.Bill => new Bill()
            };
        }
    }
}