using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CurrencyConverter.Data.Entities
{
    public class Currency
    {
        [Key]
        public Guid Uid { get; set; }

        public string FullName { get; set; }
        public string ShortName { get; set; }
        public decimal PurchaseRate { get; set; }
        public decimal SellRate { get; set; }
        public int IsDefaultCurrency { get; set; }

        [ForeignKey("RoundingPolicy")]
        public string RoundingPolicyCode { get; set; }
        public virtual RoundingPolicy RoundingPolicy { get; set; }

        public DateTime SysInsertDateTime { get; set; }
        public string SysInsertUser { get; set; }
        public DateTime? SysUpdateDateTime { get; set; }
        public string SysUpdateUser { get; set; }
    }
}
