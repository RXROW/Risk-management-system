using System.Threading.Tasks;
using MyApiApp.Domain;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using System;

namespace MyApiApp.Data
{
    public class RiskResponseDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<RiskResponse, Guid> _riskResponseRepository;

        public RiskResponseDataSeedContributor(IRepository<RiskResponse, Guid> riskResponseRepository)
        {
            _riskResponseRepository = riskResponseRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _riskResponseRepository.GetCountAsync() > 0)
            {
                return;
            }

            var responses = new[]
            {
                new RiskResponse { Name = "Accept", Description = "Accept the risk" },
                new RiskResponse { Name = "Mitigate", Description = "Mitigate the risk" },
                new RiskResponse { Name = "Transfer", Description = "Transfer the risk" },
                new RiskResponse { Name = "Avoid", Description = "Avoid the risk" }
            };

            foreach (var response in responses)
            {
                response.Id = Guid.NewGuid();
                await _riskResponseRepository.InsertAsync(response, autoSave: true);
            }
        }
    }
} 