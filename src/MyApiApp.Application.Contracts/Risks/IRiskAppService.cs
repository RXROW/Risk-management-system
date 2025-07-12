using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MyApiApp.Application.Contracts.Risks
{
    public interface IRiskAppService : IApplicationService
    {
        Task<RiskDto> GetAsync(Guid id);
        Task<RiskWithDetailsDto> GetWithDetailsAsync(Guid id);
        Task<List<RiskDto>> GetListAsync();
        Task<List<RiskWithDetailsDto>> GetListWithDetailsAsync();
        Task<RiskDto> CreateAsync(CreateUpdateRiskDto input);
        Task<RiskDto> UpdateAsync(Guid id, CreateUpdateRiskDto input);
        Task DeleteAsync(Guid id);
    }
} 