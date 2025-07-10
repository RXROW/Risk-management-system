using System.Threading.Tasks;
using MyApiApp.Domain;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Data
{
    public class RiskCategoryDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<RiskCategory, System.Guid> _riskCategoryRepository;

        public RiskCategoryDataSeedContributor(IRepository<RiskCategory, System.Guid> riskCategoryRepository)
        {
            _riskCategoryRepository = riskCategoryRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _riskCategoryRepository.GetCountAsync() > 0)
            {
                return;
            }

            var categories = new[]
            {
                new RiskCategory { Id = System.Guid.NewGuid(), Name = "Operational", Description = "Operational risks" },
                new RiskCategory { Id = System.Guid.NewGuid(), Name = "Compliance", Description = "Compliance risks" },
                new RiskCategory { Id = System.Guid.NewGuid(), Name = "Financial", Description = "Financial risks" },
                new RiskCategory { Id = System.Guid.NewGuid(), Name = "Strategic", Description = "Strategic risks" },
                new RiskCategory { Id = System.Guid.NewGuid(), Name = "Reputational", Description = "Reputational risks" }
            };

            foreach (var category in categories)
            {
                await _riskCategoryRepository.InsertAsync(category, autoSave: true);
            }
        }
    }
} 