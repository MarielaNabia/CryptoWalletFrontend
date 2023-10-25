namespace CryptoWalletFrontend.Data.DTOs
{
    public class TransferDto
    {
        public string SourceIdentifier { get; set; }
        public string DestinationIdentifier { get; set; }
        public decimal Amount { get; set; }
    }
}
