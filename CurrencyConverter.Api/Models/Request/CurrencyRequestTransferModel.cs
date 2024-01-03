using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Api.Models.Request
{
    public class CurrencyRequestTransferModel
    {
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(3)]
        public string ShortName { get; set; }

        [Required]
        public decimal PurchaseRate { get; set; }

        [Required]
        public decimal SellRate { get; set; }

        [Required]
        [Range(typeof(int), "0", "1")]
        public int IsDefaultCurrency { get; set; }

        [Required]
        public RoundingPolicyRequestTransferModel RoundingPolicy { get; set; }
    }
}
