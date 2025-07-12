using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using MyApiApp.Domain.Risks;

namespace MyApiApp.EntityFrameworkCore
{
    public class RiskRepository : EfCoreRepository<MyApiAppDbContext, Risk, Guid>, IRiskRepository
    {
        public RiskRepository(IDbContextProvider<MyApiAppDbContext> dbContextProvider) 
            : base(dbContextProvider)
        {
        }

        public async Task<Risk> GetWithDetailsAsync(Guid id)
        {
            var dbContext = await GetDbContextAsync();
            
            return await dbContext.Set<Risk>()
                .Include(r => r.Entity)
                .Include(r => r.FunctionalDomain)
                .Include(r => r.DomainArea)
                .Include(r => r.RiskCategory)
                .Include(r => r.RiskResponse)
                .Include(r => r.RiskStage)
                .Include(r => r.RiskStatement)
                .Include(r => r.RiskOwningGroup)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Risk>> GetListWithDetailsAsync()
        {
            var dbContext = await GetDbContextAsync();
            
            return await dbContext.Set<Risk>()
                .Include(r => r.Entity)
                .Include(r => r.FunctionalDomain)
                .Include(r => r.DomainArea)
                .Include(r => r.RiskCategory)
                .Include(r => r.RiskResponse)
                .Include(r => r.RiskStage)
                .Include(r => r.RiskStatement)
                .Include(r => r.RiskOwningGroup)
                .ToListAsync();
        }
    }
} 