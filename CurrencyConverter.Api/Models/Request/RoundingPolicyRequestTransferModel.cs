using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Api.Models.Request
{
    public class RoundingPolicyRequestTransferModel
    {
        [Required]
        [MaxLength(5)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
