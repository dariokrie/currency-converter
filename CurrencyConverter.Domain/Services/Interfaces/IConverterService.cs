using CurrencyConverter.Domain.Models;

namespace CurrencyConverter.Domain.Services.Interfaces
{
    public interface IConverterService
    {
        Task<ConverterDomainModel> ConvertValueFromDefaultCurrency(string currencyShortName, decimal value);
        Task<ConverterDomainModel> ConvertValueToDefaultCurrency(string currencyShortName, decimal value);
    }
}
