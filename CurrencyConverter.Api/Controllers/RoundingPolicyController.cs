using AutoMapper;
using CurrencyConverter.Api.Models.Request;
using CurrencyConverter.Api.Models.Response;
using CurrencyConverter.Domain.Models;
using CurrencyConverter.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Api.Controllers
{
    [ApiController]
    [Route("api/policy")]
    public class RoundingPolicyController : Controller
    {
        private readonly IRoundingPolicyService _policyService;
        private readonly IMapper _mapper;

        public RoundingPolicyController(IRoundingPolicyService policyService, IMapper mapper)
        {
            _policyService = policyService;
            _mapper = mapper;
        }

        [HttpGet("GetPolicies")]
        [ProducesResponseType(typeof(IEnumerable<RoundingPolicyResponseTransferModel>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<RoundingPolicyRequestTransferModel>>> GetPoliciesAsync()
        {
            var policyDomainModels = await _policyService.GetRoundingPoliciesAsync();
            var policyResponseTransferModel =
                _mapper.Map<IEnumerable<RoundingPolicyDomainModel>, IEnumerable<RoundingPolicyResponseTransferModel>>(policyDomainModels);

            return Ok(policyResponseTransferModel);
        }

        [HttpPost("PostPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> PostPolicyAsync(RoundingPolicyRequestTransferModel request)
        {
            var policyDomainModel = _mapper.Map<RoundingPolicyRequestTransferModel, RoundingPolicyDomainModel>(request);
            await _policyService.InsertPolicyAsync(policyDomainModel);

            return Created();
        }
    }
}
