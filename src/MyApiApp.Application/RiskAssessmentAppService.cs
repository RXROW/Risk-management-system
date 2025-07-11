using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyApiApp.Application.Contracts;
using MyApiApp.Domain;
using MyApiApp.Domain.Shared;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MyApiApp.Application
{
    public class RiskAssessmentAppService : ApplicationService, IRiskAssessmentAppService
    {
        private readonly IRepository<RiskAssessment, Guid> _repository;

        public RiskAssessmentAppService(IRepository<RiskAssessment, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<RiskAssessmentDto>> GetListAsync()
        {
            var items = await _repository.GetListAsync();
            return items.Select(ra => new RiskAssessmentDto
            {
                Id = ra.Id,
                AssessmentDate = ra.AssessmentDate,
                LikelihoodLevel = ra.LikelihoodLevel,
                ImpactLevel = ra.ImpactLevel,
                OverallRating = ra.OverallRating,
                AssessedById = ra.AssessedById,
                RiskId = ra.RiskId
            }).ToList();
        }

        public async Task<RiskAssessmentDto> GetAsync(Guid id)
        {
            var ra = await _repository.GetAsync(id);
            return new RiskAssessmentDto
            {
                Id = ra.Id,
                AssessmentDate = ra.AssessmentDate,
                LikelihoodLevel = ra.LikelihoodLevel,
                ImpactLevel = ra.ImpactLevel,
                OverallRating = ra.OverallRating,
                AssessedById = ra.AssessedById,
                RiskId = ra.RiskId
            };
        }

        public async Task<RiskAssessmentDto> CreateAsync(CreateUpdateRiskAssessmentDto input)
        {
            var ra = new RiskAssessment(GuidGenerator.Create())
            {
                AssessmentDate = input.AssessmentDate,
                LikelihoodLevel = input.LikelihoodLevel,
                ImpactLevel = input.ImpactLevel,
                OverallRating = input.OverallRating,
                AssessedById = input.AssessedById,
                RiskId = input.RiskId
            };
            await _repository.InsertAsync(ra, autoSave: true);
            return new RiskAssessmentDto
            {
                Id = ra.Id,
                AssessmentDate = ra.AssessmentDate,
                LikelihoodLevel = ra.LikelihoodLevel,
                ImpactLevel = ra.ImpactLevel,
                OverallRating = ra.OverallRating,
                AssessedById = ra.AssessedById,
                RiskId = ra.RiskId
            };
        }

        public async Task<RiskAssessmentDto> UpdateAsync(Guid id, CreateUpdateRiskAssessmentDto input)
        {
            var ra = await _repository.GetAsync(id);
            ra.AssessmentDate = input.AssessmentDate;
            ra.LikelihoodLevel = input.LikelihoodLevel;
            ra.ImpactLevel = input.ImpactLevel;
            ra.OverallRating = input.OverallRating;
            ra.AssessedById = input.AssessedById;
            ra.RiskId = input.RiskId;
            await _repository.UpdateAsync(ra, autoSave: true);
            return new RiskAssessmentDto
            {
                Id = ra.Id,
                AssessmentDate = ra.AssessmentDate,
                LikelihoodLevel = ra.LikelihoodLevel,
                ImpactLevel = ra.ImpactLevel,
                OverallRating = ra.OverallRating,
                AssessedById = ra.AssessedById,
                RiskId = ra.RiskId
            };
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
} 