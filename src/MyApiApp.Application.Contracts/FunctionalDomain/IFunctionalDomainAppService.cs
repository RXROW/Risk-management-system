using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApiApp.Application.Contracts
{
    public interface IFunctionalDomainAppService
    {
        Task<List<FunctionalDomainDto>> GetListAsync();
        Task<FunctionalDomainDto> GetAsync(Guid id);
        Task<FunctionalDomainDto> CreateAsync(CreateUpdateFunctionalDomainDto input);
        Task<FunctionalDomainDto> UpdateAsync(Guid id, CreateUpdateFunctionalDomainDto input);
        Task DeleteAsync(Guid id);
    }
} 