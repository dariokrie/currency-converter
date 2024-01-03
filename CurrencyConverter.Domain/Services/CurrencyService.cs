using AutoMapper;
using CurrencyConverter.Data.Entities;
using CurrencyConverter.Data.Repositories.Interfaces;
using CurrencyConverter.Domain.Models;
using CurrencyConverter.Domain.Services.Interfaces;

namespace CurrencyConverter.Domain.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IRoundingPolicyRepository _policyRepository;
        private readonly IMapper _mapper;

        public CurrencyService(ICurrencyRepository currencyRepository, IRoundingPolicyRepository policyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _policyRepository = policyRepository;
            _mapper = mapper;
        }

        public async Task<List<CurrencyDomainModel>> GetCurrenciesAsync()
        {
            var currencies = await _currencyRepository.GetCurrenciesAsync();
            var currencyDomainModel = _mapper.Map<List<Currency>, List<CurrencyDomainModel>>(currencies);

            return currencyDomainModel;
        }

        public async Task InsertCurrencyAsync(CurrencyDomainModel currency)
        {
            var policies = await _policyRepository.GetPoliciesAsync();

            var newCurrency = new Currency
            {
                Uid = Guid.NewGuid(),
                FullName = currency.FullName,
                ShortName = currency.ShortName,
                PurchaseRate = currency.PurchaseRate,
                SellRate = currency.SellRate,
                IsDefaultCurrency = currency.IsDefaultCurrency,
                RoundingPolicyCode = currency.RoundingPolicy.Code,
                RoundingPolicy = policies.Find(p => p.Code == currency.RoundingPolicy.Code),

                SysInsertDateTime = DateTime.Now,
                SysInsertUser = "CurrencyConverter System, CurrencyService.cs",
                SysUpdateDateTime = null,
                SysUpdateUser = ""
            };

            await _currencyRepository.InsertCurrencyAsync(newCurrency);
        }
    }
}
