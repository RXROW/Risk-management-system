using System.Threading.Tasks;
using MyApiApp.Domain;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using System;

namespace MyApiApp.Data
{
    public class RiskStageDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<RiskStage, Guid> _riskStageRepository;

        public RiskStageDataSeedContributor(IRepository<RiskStage, Guid> riskStageRepository)
        {
            _riskStageRepository = riskStageRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _riskStageRepository.GetCountAsync() > 0)
            {
                return;
            }

            var stages = new[]
            {
                new RiskStage { Name = "Draft", Description = "Draft stage" },
                new RiskStage { Name = "Assess", Description = "Assessment stage" },
                new RiskStage { Name = "Respond", Description = "Response stage" },
                new RiskStage { Name = "Review", Description = "Review stage" },
                new RiskStage { Name = "Monitor", Description = "Monitoring stage" },
                new RiskStage { Name = "Retired", Description = "Retired stage" }
            };

            foreach (var stage in stages)
            {
                stage.Id = Guid.NewGuid();
                await _riskStageRepository.InsertAsync(stage, autoSave: true);
            }
        }
    }
} 