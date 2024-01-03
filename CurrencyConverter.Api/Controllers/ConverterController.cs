using AutoMapper;
using CurrencyConverter.Api.Models.Request;
using CurrencyConverter.Api.Models.Response;
using CurrencyConverter.Domain.Models;
using CurrencyConverter.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Api.Controllers
{
    [Route("api/converter")]
    [ApiController]
    public class ConverterController : Controller
    {
        private readonly IConverterService _converterService;
        private readonly IMapper _mapper;

        public ConverterController(IConverterService  converterService, IMapper mapper)
        {
            _converterService = converterService;
            _mapper = mapper;
        }

        [HttpPost("ConvertFromDefaultCurrency")]
        [ProducesResponseType(typeof(ConverterResponseTransferModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<decimal>> PostConversionFromDefaultCurrency(ConverterRequestTransferModel request)
        {
            var converterDomainModel =
                await _converterService.ConvertValueFromDefaultCurrency(request.CurrencyShortName, request.Value);

            var converterResponseTransferModel =
                _mapper.Map<ConverterDomainModel, ConverterResponseTransferModel>(converterDomainModel);

            return Ok(converterResponseTransferModel);
        }

        [HttpPost("ConvertToDefaultCurrency")]
        [ProducesResponseType(typeof(ConverterResponseTransferModel), StatusCodes.Status200OK)]
        public async Task<ActionResult<decimal>> PostConversionToDefaultCurrency(ConverterRequestTransferModel request)
        {
            var converterDomainModel =
                await _converterService.ConvertValueToDefaultCurrency(request.CurrencyShortName, request.Value);

            var converterResponseTransferModel =
                _mapper.Map<ConverterDomainModel, ConverterResponseTransferModel>(converterDomainModel);

            return Ok(converterResponseTransferModel);
        }
    }
}
