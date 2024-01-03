using CurrencyConverter.Data.Repositories.Interfaces;
using CurrencyConverter.Domain.Models;
using CurrencyConverter.Domain.Services.Interfaces;

namespace CurrencyConverter.Domain.Services
{
    public class ConverterService : IConverterService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public ConverterService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<ConverterDomainModel> ConvertValueFromDefaultCurrency(string currencyShortName, decimal value)
        {
            var currency = await _currencyRepository.GetCurrencyAsync(currencyShortName);
            var exchangeRate = currency.PurchaseRate;

            return new ConverterDomainModel { Value = value * exchangeRate };
        }

        public async Task<ConverterDomainModel> ConvertValueToDefaultCurrency(string currencyShortName, decimal value)
        {
            var currency = await _currencyRepository.GetCurrencyAsync(currencyShortName);
            var exchangeRate = currency.SellRate;

            return new ConverterDomainModel { Value = value / exchangeRate };
        }
    }
}
