using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyApiApp.Application.Contracts
{
    public interface IOwningGroupAppService
    {
        Task<List<OwningGroupDto>> GetListAsync();
        Task<OwningGroupDto> GetAsync(Guid id);
        Task<OwningGroupDto> CreateAsync(CreateUpdateOwningGroupDto input);
        Task<OwningGroupDto> UpdateAsync(Guid id, CreateUpdateOwningGroupDto input);
        Task DeleteAsync(Guid id);
    }
} 