using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApiApp.Application.Contracts
{
    public interface IRiskStatementAppService
    {
        Task<List<RiskStatementDto>> GetListAsync();
        Task<RiskStatementDto> GetAsync(Guid id);
        Task<RiskStatementDto> CreateAsync(CreateUpdateRiskStatementDto input);
        Task<RiskStatementDto> UpdateAsync(Guid id, CreateUpdateRiskStatementDto input);
        Task DeleteAsync(Guid id);
    }
} 