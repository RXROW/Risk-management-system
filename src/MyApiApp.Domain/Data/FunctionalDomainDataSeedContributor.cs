using System.Threading.Tasks;
using MyApiApp.Domain;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Data
{
    public class FunctionalDomainDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<FunctionalDomain, System.Guid> _functionalDomainRepository;

        public FunctionalDomainDataSeedContributor(IRepository<FunctionalDomain, System.Guid> functionalDomainRepository)
        {
            _functionalDomainRepository = functionalDomainRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _functionalDomainRepository.GetCountAsync() > 0)
            {
                return;
            }

            var domains = new[]
            {
                new FunctionalDomain(System.Guid.NewGuid()) { Name = "Finance", Description = "Finance domain" },
                new FunctionalDomain(System.Guid.NewGuid()) { Name = "IT", Description = "Information Technology domain" },
                new FunctionalDomain(System.Guid.NewGuid()) { Name = "Legal", Description = "Legal domain" },
                new FunctionalDomain(System.Guid.NewGuid()) { Name = "HR", Description = "Human Resources domain" }
            };

            foreach (var domain in domains)
            {
                await _functionalDomainRepository.InsertAsync(domain, autoSave: true);
            }
        }
    }
} 