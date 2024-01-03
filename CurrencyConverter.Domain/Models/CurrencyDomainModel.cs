namespace CurrencyConverter.Domain.Models
{
    public class CurrencyDomainModel
    {
        public Guid Uid { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SellRate { get; set; }
        public int IsDefaultCurrency { get; set; }

        public RoundingPolicyDomainModel RoundingPolicy { get; set; }
    }
}
