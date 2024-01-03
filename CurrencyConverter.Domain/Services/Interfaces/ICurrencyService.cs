using CurrencyConverter.Domain.Models;

namespace CurrencyConverter.Domain.Services.Interfaces
{
    public interface ICurrencyService
    {
        Task<List<CurrencyDomainModel>> GetCurrenciesAsync();
        Task InsertCurrencyAsync(CurrencyDomainModel currency);
    }
}
