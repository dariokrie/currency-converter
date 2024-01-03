using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Data.Entities.Interfaces
{
    public interface ICurrencyConverterContext
    {
        DbSet<Currency> Currencies { get; set; }
        DbSet<RoundingPolicy> RoundingPolicies { get; set; }

        int SaveChanges();
    }
}
