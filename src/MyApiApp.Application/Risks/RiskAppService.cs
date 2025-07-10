using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyApiApp.Risks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Risks
{
    public class RiskAppService : ApplicationService
    {
        private readonly IRepository<Risk, Guid> _riskRepository;

        public RiskAppService(IRepository<Risk, Guid> riskRepository)
        {
            _riskRepository = riskRepository;
        }

        public async Task<RiskDto> GetAsync(Guid id)
        {
            var risk = await _riskRepository.GetAsync(id);
            return ObjectMapper.Map<Risk, RiskDto>(risk);
        }

        public async Task<List<RiskDto>> GetListAsync()
        {
            var risks = await _riskRepository.GetListAsync();
            return ObjectMapper.Map<List<Risk>, List<RiskDto>>(risks);
        }

        public async Task<RiskDto> CreateAsync(CreateUpdateRiskDto input)
        {
            var risk = ObjectMapper.Map<CreateUpdateRiskDto, Risk>(input);
            var created = await _riskRepository.InsertAsync(risk, autoSave: true);
            return ObjectMapper.Map<Risk, RiskDto>(created);
        }

        public async Task<RiskDto> UpdateAsync(Guid id, CreateUpdateRiskDto input)
        {
            var risk = await _riskRepository.GetAsync(id);
            ObjectMapper.Map(input, risk);
            var updated = await _riskRepository.UpdateAsync(risk, autoSave: true);
            return ObjectMapper.Map<Risk, RiskDto>(updated);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _riskRepository.DeleteAsync(id);
        }
    }
} 