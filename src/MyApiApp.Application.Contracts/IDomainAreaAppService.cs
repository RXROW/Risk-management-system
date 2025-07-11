using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApiApp.Application.Contracts
{
    public interface IDomainAreaAppService
    {
        Task<List<DomainAreaDto>> GetListAsync();
        Task<DomainAreaDto> GetAsync(Guid id);
        Task<DomainAreaDto> CreateAsync(CreateUpdateDomainAreaDto input);
        Task<DomainAreaDto> UpdateAsync(Guid id, CreateUpdateDomainAreaDto input);
        Task DeleteAsync(Guid id);
    }
} 