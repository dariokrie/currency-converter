using System.ComponentModel.DataAnnotations;

namespace CurrencyConverter.Data.Entities
{
    public class RoundingPolicy
    {
        [Key]
        public string Code { get; set; }

        public string Description { get; set; }

        public DateTime SysInsertDateTime { get; set; }
        public string SysInsertUser { get; set; }
        public DateTime? SysUpdateDateTime { get; set; }
        public string SysUpdateUser { get; set; }
    }
}
