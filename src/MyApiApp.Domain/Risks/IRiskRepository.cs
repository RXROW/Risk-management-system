using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Domain.Risks
{
    public interface IRiskRepository : IRepository<Risk, Guid>
    {
        Task<Risk> GetWithDetailsAsync(Guid id);
        Task<List<Risk>> GetListWithDetailsAsync();
    }
} 