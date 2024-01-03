using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Api.Models.Request
{
    public class ConverterRequestTransferModel
    {
        [Required]
        [StringLength(3, ErrorMessage = "The currency code can only be 3 characters")]
        public string CurrencyShortName { get; set; }

        [Required]
        public decimal Value { get; set; }
    }
}
