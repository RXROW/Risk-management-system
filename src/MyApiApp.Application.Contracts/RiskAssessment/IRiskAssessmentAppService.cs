using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApiApp.Application.Contracts
{
    public interface IRiskAssessmentAppService
    {
        Task<List<RiskAssessmentDto>> GetListAsync();
        Task<RiskAssessmentDto> GetAsync(Guid id);
        Task<RiskAssessmentDto> CreateAsync(CreateUpdateRiskAssessmentDto input);
        Task<RiskAssessmentDto> UpdateAsync(Guid id, CreateUpdateRiskAssessmentDto input);
        Task DeleteAsync(Guid id);
    }
} 