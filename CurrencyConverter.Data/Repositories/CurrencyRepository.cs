using CurrencyConverter.Data.Entities;
using CurrencyConverter.Data.Entities.Interfaces;
using CurrencyConverter.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Data.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly ICurrencyConverterContext _context;

        public CurrencyRepository(ICurrencyConverterContext context)
        {
            _context = context;
        }

        public async Task<List<Currency>> GetCurrenciesAsync()
        {
            return await _context.Currencies
                .Include(c => c.RoundingPolicy)
                .ToListAsync();
        }

        public async Task<Currency> GetCurrencyAsync(string currencyShortName)
        {
            return await _context.Currencies
                .FirstOrDefaultAsync(c => c.ShortName == currencyShortName);
        }

        public async Task InsertCurrencyAsync(Currency currency)
        {
            await _context.Currencies.AddAsync(currency);
            _context.SaveChanges();
        }
    }
}
