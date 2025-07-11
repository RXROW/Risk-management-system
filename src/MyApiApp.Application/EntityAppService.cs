using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using MyApiApp.Domain;

namespace MyApiApp
{
    public class EntityAppService : ApplicationService
    {
        private readonly IRepository<Entity, Guid> _entityRepository;

        public EntityAppService(IRepository<Entity, Guid> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task<EntityDto> GetAsync(Guid id)
        {
            var entity = await _entityRepository.GetAsync(id);
            return ObjectMapper.Map<Entity, EntityDto>(entity);
        }

        public async Task<List<EntityDto>> GetListAsync()
        {
            var entities = await _entityRepository.GetListAsync();
            return ObjectMapper.Map<List<Entity>, List<EntityDto>>(entities);
        }

        public async Task<EntityDto> CreateAsync(CreateUpdateEntityDto input)
        {
            var entity = ObjectMapper.Map<CreateUpdateEntityDto, Entity>(input);
            var created = await _entityRepository.InsertAsync(entity, autoSave: true);
            return ObjectMapper.Map<Entity, EntityDto>(created);
        }

        public async Task<EntityDto> UpdateAsync(Guid id, CreateUpdateEntityDto input)
        {
            var entity = await _entityRepository.GetAsync(id);
            ObjectMapper.Map(input, entity);
            var updated = await _entityRepository.UpdateAsync(entity, autoSave: true);
            return ObjectMapper.Map<Entity, EntityDto>(updated);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _entityRepository.DeleteAsync(id);
        }
    }
} 