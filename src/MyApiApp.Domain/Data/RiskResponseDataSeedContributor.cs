using System.Threading.Tasks;
using MyApiApp.Domain;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Data
{
    public class RiskResponseDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<RiskResponse, int> _riskResponseRepository;

        public RiskResponseDataSeedContributor(IRepository<RiskResponse, int> riskResponseRepository)
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
                new RiskResponse { Name = "None", Description = "No response selected" },
                new RiskResponse { Name = "Avoid", Description = "Avoid the risk" },
                new RiskResponse { Name = "Mitigate", Description = "Mitigate the risk" },
                new RiskResponse { Name = "Transfer", Description = "Transfer the risk" },
                new RiskResponse { Name = "Accept", Description = "Accept the risk" }
            };

            foreach (var response in responses)
            {
                await _riskResponseRepository.InsertAsync(response, autoSave: true);
            }
        }
    }
} 