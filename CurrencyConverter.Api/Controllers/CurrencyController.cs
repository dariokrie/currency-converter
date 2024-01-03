using AutoMapper;
using CurrencyConverter.Api.Models.Request;
using CurrencyConverter.Api.Models.Response;
using CurrencyConverter.Domain.Models;
using CurrencyConverter.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Api.Controllers
{
    [Route("api/currency")]
    [ApiController]
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public CurrencyController(IMapper mapper, ICurrencyService currencyService)
        {
            _mapper = mapper;
            _currencyService = currencyService; 
        }

        [HttpGet("GetCurrencies")]
        [ProducesResponseType(typeof(IEnumerable<CurrencyResponseTransferModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CurrencyRequestTransferModel>>> GetCurrenciesAsync()
        {
            var currencyDomainModels = await _currencyService.GetCurrenciesAsync();
            var currencyResponseTransferModels = _mapper.Map<IEnumerable<CurrencyDomainModel>, IEnumerable<CurrencyResponseTransferModel>>(currencyDomainModels);

            return Ok(currencyResponseTransferModels);
        }

        [HttpPost("PostCurrency")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Guid>> PostCurrencyAsync(CurrencyRequestTransferModel request)
        {
            var currencyDomainModel = _mapper.Map<CurrencyRequestTransferModel, CurrencyDomainModel>(request);
            await _currencyService.InsertCurrencyAsync(currencyDomainModel);

            return Created();
        }
    }
}
