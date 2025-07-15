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
    public class FunctionalDomainAppService : ApplicationService, IFunctionalDomainAppService
    {
        private readonly IRepository<FunctionalDomain, Guid> _repository;

        public FunctionalDomainAppService(IRepository<FunctionalDomain, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<FunctionalDomainDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return items.Select(fd => new FunctionalDomainDto
            {
                Id = fd.Id,
                Name = fd.Name,
                Description = fd.Description
            }).ToList();
        }

        public async Task<FunctionalDomainDto> GetAsync(Guid id)
        {
            var fd = await _repository.GetAsync(id);
            return new FunctionalDomainDto
            {
                Id = fd.Id,
                Name = fd.Name,
                Description = fd.Description
            };
        }

        public async Task<FunctionalDomainDto> CreateAsync(CreateUpdateFunctionalDomainDto input)
        {
            var fd = new FunctionalDomain(GuidGenerator.Create())
            {
                Name = input.Name,
                Description = input.Description
            };
            await _repository.InsertAsync(fd, autoSave: true);
            return new FunctionalDomainDto
            {
                Id = fd.Id,
                Name = fd.Name,
                Description = fd.Description
            };
        }

        public async Task<FunctionalDomainDto> UpdateAsync(Guid id, CreateUpdateFunctionalDomainDto input)
        {
            var fd = await _repository.GetAsync(id);
            fd.Name = input.Name;
            fd.Description = input.Description;
            await _repository.UpdateAsync(fd, autoSave: true);
            return new FunctionalDomainDto
            {
                Id = fd.Id,
                Name = fd.Name,
                Description = fd.Description
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
} 