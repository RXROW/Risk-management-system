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
    public class OwningGroupAppService : ApplicationService, IOwningGroupAppService
    {
        private readonly IRepository<OwningGroup, Guid> _repository;

        public OwningGroupAppService(IRepository<OwningGroup, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<OwningGroupDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return items.Select(og => new OwningGroupDto
            {
                Id = og.Id,
                Name = og.Name
            }).ToList();
        }

        public async Task<OwningGroupDto> GetAsync(Guid id)
        {
            var og = await _repository.GetAsync(id);
            return new OwningGroupDto
            {
                Id = og.Id,
                Name = og.Name
            };
        }

        public async Task<OwningGroupDto> CreateAsync(CreateUpdateOwningGroupDto input)
        {
            var og = new OwningGroup(GuidGenerator.Create())
            {
                Name = input.Name
            };
            await _repository.InsertAsync(og, autoSave: true);
            return new OwningGroupDto
            {
                Id = og.Id,
                Name = og.Name
            };
        }

        public async Task<OwningGroupDto> UpdateAsync(Guid id, CreateUpdateOwningGroupDto input)
        {
            var og = await _repository.GetAsync(id);
            og.Name = input.Name;
            await _repository.UpdateAsync(og, autoSave: true);
            return new OwningGroupDto
            {
                Id = og.Id,
                Name = og.Name
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
} 