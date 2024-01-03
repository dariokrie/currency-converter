using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Data.Entities
{
    public partial class CurrencyConverterContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<RoundingPolicy> RoundingPolicies { get; set; }
    }
}
