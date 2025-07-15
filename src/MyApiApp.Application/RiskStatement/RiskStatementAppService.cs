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
    public class RiskStatementAppService : ApplicationService, IRiskStatementAppService
    {
        private readonly IRepository<RiskStatement, Guid> _repository;

        public RiskStatementAppService(IRepository<RiskStatement, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<RiskStatementDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return items.Select(rs => new RiskStatementDto
            {
                Id = rs.Id,
                Statement = rs.Statement,
                CreatedDate = rs.CreatedDate
            }).ToList();
        }

        public async Task<RiskStatementDto> GetAsync(Guid id)
        {
            var rs = await _repository.GetAsync(id);
            return new RiskStatementDto
            {
                Id = rs.Id,
                Statement = rs.Statement,
                CreatedDate = rs.CreatedDate
            };
        }

        public async Task<RiskStatementDto> CreateAsync(CreateUpdateRiskStatementDto input)
        {
            var rs = new RiskStatement(GuidGenerator.Create())
            {
                Statement = input.Statement,
                CreatedDate = input.CreatedDate
            };
            await _repository.InsertAsync(rs, autoSave: true);
            return new RiskStatementDto
            {
                Id = rs.Id,
                Statement = rs.Statement,
                CreatedDate = rs.CreatedDate
            };
        }

        public async Task<RiskStatementDto> UpdateAsync(Guid id, CreateUpdateRiskStatementDto input)
        {
            var rs = await _repository.GetAsync(id);
            rs.Statement = input.Statement;
            rs.CreatedDate = input.CreatedDate;
            await _repository.UpdateAsync(rs, autoSave: true);
            return new RiskStatementDto
            {
                Id = rs.Id,
                Statement = rs.Statement,
                CreatedDate = rs.CreatedDate
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
} 