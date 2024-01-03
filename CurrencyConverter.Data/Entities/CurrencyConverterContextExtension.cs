using CurrencyConverter.Data.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Data.Entities
{
    public partial class CurrencyConverterContext : ICurrencyConverterContext
    {
        public CurrencyConverterContext(DbContextOptions<CurrencyConverterContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
