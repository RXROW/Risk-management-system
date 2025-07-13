using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApiApp.Application.Contracts.Risks;
using Volo.Abp.AspNetCore.Mvc;

namespace MyApiApp.HttpApi.Controllers
{
    [Route("api/risks")]
    public class RiskController : AbpController
    {
        private readonly IRiskAppService _riskAppService;

        public RiskController(IRiskAppService riskAppService)
        {
            _riskAppService = riskAppService;
        }

        [HttpGet]
        public async Task<List<RiskDto>> GetListAsync()
        {
            return await _riskAppService.GetListAsync();
        }

        [HttpGet("with-details")]
        public async Task<List<RiskWithDetailsDto>> GetListWithDetailsAsync()
        {
            return await _riskAppService.GetListWithDetailsAsync();
        }

        [HttpGet("{id}")]
        public async Task<RiskDto> GetAsync(Guid id)
        {
            return await _riskAppService.GetAsync(id);
        }

        [HttpGet("{id}/with-details")]
        public async Task<RiskWithDetailsDto> GetWithDetailsAsync(Guid id)
        {
            return await _riskAppService.GetWithDetailsAsync(id);
        }

        [HttpPost]
        public async Task<RiskDto> CreateAsync([FromBody] CreateUpdateRiskDto input)
        {
            return await _riskAppService.CreateAsync(input);
        }

        [HttpPut("{id}")]
        public async Task<RiskDto> UpdateAsync(Guid id, [FromBody] CreateUpdateRiskDto input)
        {
            return await _riskAppService.UpdateAsync(id, input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(Guid id)
        {
            await _riskAppService.DeleteAsync(id);
        }
    }
} 