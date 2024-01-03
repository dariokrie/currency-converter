using AutoMapper;
using CurrencyConverter.Api.Models.Request;
using CurrencyConverter.Api.Models.Response;
using CurrencyConverter.Data.Entities;
using CurrencyConverter.Domain.Models;

namespace CurrencyConverter.Api.Profiles
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyRequestTransferModel, CurrencyDomainModel>()
                .ForMember(
                    dest => dest.RoundingPolicy,
                    opt => opt.MapFrom(src => src.RoundingPolicy));

            CreateMap<CurrencyDomainModel, CurrencyResponseTransferModel>()
                .ForMember(
                    dest => dest.RoundingPolicyCode,
                    opt => opt.MapFrom(src => src.RoundingPolicy.Code));

            CreateMap<Currency, CurrencyDomainModel>()
                .ForMember(
                    dest => dest.RoundingPolicy,
                    opt => opt.MapFrom(src => src.RoundingPolicy));
        }
    }
}
