namespace CryptoWalletFrontend.ViewModels
{
    public class TransferViewModel
    {
        public string SourceAliasOrCBU { get; set; }
        public string DestinationAliasOrCBU { get; set; }
        public decimal Amount { get; set; }
    }
}
