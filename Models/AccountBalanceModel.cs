namespace CryptoWalletFrontend.Models
{
    public class AccountBalanceModel
    {
        public double PesosBalance { get; set; }
        public double UsdBalance { get; set; }
        public double BtcBalance { get; set; }
    }
    public class CuentaDto { 
        public string Cuenta { get; set; }
        public double Saldo { get; set; } }
}
