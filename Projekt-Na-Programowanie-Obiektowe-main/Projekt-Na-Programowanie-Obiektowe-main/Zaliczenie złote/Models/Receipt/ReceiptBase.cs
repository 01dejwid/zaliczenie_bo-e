using System.Text;

namespace Zaliczenie.Models.Receipt
{
    public abstract class ReceiptBase
    {
        public ReceiptBase()
        {
        }

        private const string SaveFolder = "Receipt";

        public abstract void CreateReceipt();

        public void ShowReceipt(string receipt)
        {
            Console.Write(receipt);
        }

        public void SaveReceipt(string receipt)
        {
            var directoryPath = System.IO.Directory.GetCurrentDirectory();
            var savePath = Path.Combine(directoryPath, SaveFolder);
            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            var generationGuid = Guid.NewGuid();
            var fullPath = Path.Combine(savePath, $"Bill_{generationGuid}.txt");
            using (var file = File.Create(fullPath))
            {
                var bytes = Encoding.ASCII.GetBytes(receipt);
                file.Write(bytes, 0, bytes.Count());
            };
        }
    }
}