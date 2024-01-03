using CurrencyConverter.Data.Entities;

namespace CurrencyConverter.Data.Repositories.Interfaces
{
    public interface IRoundingPolicyRepository
    {
        Task<List<RoundingPolicy>> GetPoliciesAsync();
        Task InsertPolicyAsync(RoundingPolicy policy);
    }
}
