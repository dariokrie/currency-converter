using CurrencyConverter.Domain.Models;

namespace CurrencyConverter.Domain.Services.Interfaces
{
    public interface IRoundingPolicyService
    {
        Task<List<RoundingPolicyDomainModel>> GetRoundingPoliciesAsync();
        Task InsertPolicyAsync(RoundingPolicyDomainModel roundingPolicy);
    }
}
