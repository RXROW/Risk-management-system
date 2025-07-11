using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApiApp.Application.Contracts;
using MyApiApp.Domain;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Application
{
    public class DomainAreaAppService : ApplicationService, IDomainAreaAppService
    {
        private readonly IRepository<DomainArea, Guid> _repository;
        private readonly IRepository<FunctionalDomain, Guid> _functionalDomainRepository;

        public DomainAreaAppService(
            IRepository<DomainArea, Guid> repository,
            IRepository<FunctionalDomain, Guid> functionalDomainRepository)
        {
            _repository = repository;
            _functionalDomainRepository = functionalDomainRepository;
        }

        public async Task<List<DomainAreaDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            var functionalDomains = await _functionalDomainRepository.GetListAsync();
            return items.Select(da => new DomainAreaDto
            {
                Id = da.Id,
                Name = da.Name,
                Description = da.Description,
                FunctionalDomainId = da.FunctionalDomainId,
                FunctionalDomainName = functionalDomains.FirstOrDefault(fd => fd.Id == da.FunctionalDomainId)?.Name
            }).ToList();
        }

        public async Task<DomainAreaDto> GetAsync(Guid id)
        {
            var da = await _repository.GetAsync(id);
            var fd = await _functionalDomainRepository.GetAsync(da.FunctionalDomainId);
            return new DomainAreaDto
            {
                Id = da.Id,
                Name = da.Name,
                Description = da.Description,
                FunctionalDomainId = da.FunctionalDomainId,
                FunctionalDomainName = fd?.Name
            };
        }

        public async Task<DomainAreaDto> CreateAsync(CreateUpdateDomainAreaDto input)
        {
            var da = new DomainArea(GuidGenerator.Create())
            {
                Name = input.Name,
                Description = input.Description,
                FunctionalDomainId = input.FunctionalDomainId
            };
            await _repository.InsertAsync(da, autoSave: true);
            var fd = await _functionalDomainRepository.GetAsync(da.FunctionalDomainId);
            return new DomainAreaDto
            {
                Id = da.Id,
                Name = da.Name,
                Description = da.Description,
                FunctionalDomainId = da.FunctionalDomainId,
                FunctionalDomainName = fd?.Name
            };
        }

        public async Task<DomainAreaDto> UpdateAsync(Guid id, CreateUpdateDomainAreaDto input)
        {
            var da = await _repository.GetAsync(id);
            da.Name = input.Name;
            da.Description = input.Description;
            da.FunctionalDomainId = input.FunctionalDomainId;
            await _repository.UpdateAsync(da, autoSave: true);
            var fd = await _functionalDomainRepository.GetAsync(da.FunctionalDomainId);
            return new DomainAreaDto
            {
                Id = da.Id,
                Name = da.Name,
                Description = da.Description,
                FunctionalDomainId = da.FunctionalDomainId,
                FunctionalDomainName = fd?.Name
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
} 