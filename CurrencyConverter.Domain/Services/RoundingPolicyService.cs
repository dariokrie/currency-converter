using AutoMapper;
using CurrencyConverter.Data.Entities;
using CurrencyConverter.Data.Repositories.Interfaces;
using CurrencyConverter.Domain.Models;
using CurrencyConverter.Domain.Services.Interfaces;

namespace CurrencyConverter.Domain.Services
{
    public class RoundingPolicyService : IRoundingPolicyService
    {
        private readonly IRoundingPolicyRepository _policyRepository;
        private readonly IMapper _mapper;

        public RoundingPolicyService(IRoundingPolicyRepository policyRepository, IMapper mapper)
        {
            _policyRepository = policyRepository;
            _mapper = mapper;
        }

        public async Task<List<RoundingPolicyDomainModel>> GetRoundingPoliciesAsync()
        {
            var roundingPolicies = await _policyRepository.GetPoliciesAsync();
            var roundingPolicyDomainModel =
                _mapper.Map<List<RoundingPolicy>, List<RoundingPolicyDomainModel>>(roundingPolicies);

            return roundingPolicyDomainModel;
        }

        public async Task InsertPolicyAsync(RoundingPolicyDomainModel roundingPolicy)
        {
            var newRoundingPolicy = new RoundingPolicy
            {
                Code = roundingPolicy.Code,
                Description = roundingPolicy.Description,

                SysInsertDateTime = DateTime.Now,
                SysInsertUser = "CurrencyConverter System, RoundingPolicyService.cs",
                SysUpdateDateTime = null,
                SysUpdateUser = ""
            };

            await _policyRepository.InsertPolicyAsync(newRoundingPolicy);
        }
    }
}
