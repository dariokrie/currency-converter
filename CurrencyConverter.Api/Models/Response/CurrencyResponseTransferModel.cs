namespace CurrencyConverter.Api.Models.Response
{
    public class CurrencyResponseTransferModel
    {
        public Guid Uid { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SellRate { get; set; }
        public int IsDefaultCurrency { get; set; }

        public string RoundingPolicyCode { get; set; }
    }
}
