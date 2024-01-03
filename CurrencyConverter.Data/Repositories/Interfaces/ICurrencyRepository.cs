using CurrencyConverter.Data.Entities;

namespace CurrencyConverter.Data.Repositories.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<List<Currency>> GetCurrenciesAsync();
        Task<Currency> GetCurrencyAsync(string currencyShortName);
        Task InsertCurrencyAsync(Currency currency);
    }
}
