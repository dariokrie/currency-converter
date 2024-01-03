using AutoMapper;
using CurrencyConverter.Api.Models.Request;
using CurrencyConverter.Api.Models.Response;
using CurrencyConverter.Data.Entities;
using CurrencyConverter.Domain.Models;

namespace CurrencyConverter.Api.Profiles
{
    public class RoundingPolicyProfile : Profile
    {
        public RoundingPolicyProfile()
        {
            CreateMap<RoundingPolicyRequestTransferModel, RoundingPolicyDomainModel>();
            CreateMap<RoundingPolicyDomainModel, RoundingPolicyResponseTransferModel>();
            CreateMap<RoundingPolicy, RoundingPolicyDomainModel>();
        }
    }
}
