using AutoMapper;
using CurrencyConverter.Api.Models.Request;
using CurrencyConverter.Api.Models.Response;
using CurrencyConverter.Domain.Models;

namespace CurrencyConverter.Api.Profiles
{
    public class ConverterProfile : Profile
    {
        public ConverterProfile()
        {
            CreateMap<ConverterRequestTransferModel, ConverterDomainModel>();

            CreateMap<ConverterDomainModel, ConverterResponseTransferModel>()
                .ForMember(
                    dest => dest.ConvertedValue,
                    opt => opt.MapFrom(src => src.Value));
        }
    }
}
