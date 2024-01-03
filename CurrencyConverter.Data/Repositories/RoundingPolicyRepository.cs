using CurrencyConverter.Data.Entities;
using CurrencyConverter.Data.Entities.Interfaces;
using CurrencyConverter.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CurrencyConverter.Data.Repositories
{
    public class RoundingPolicyRepository : IRoundingPolicyRepository
    {
        private readonly ICurrencyConverterContext _context;

        public RoundingPolicyRepository(ICurrencyConverterContext context)
        {
            _context = context;
        }

        public async Task<List<RoundingPolicy>> GetPoliciesAsync()
        {
            return await _context.RoundingPolicies.ToListAsync();
        }

        public async Task InsertPolicyAsync(RoundingPolicy policy)
        {
            await _context.RoundingPolicies.AddAsync(policy);
            _context.SaveChanges();
        }
    }
}
