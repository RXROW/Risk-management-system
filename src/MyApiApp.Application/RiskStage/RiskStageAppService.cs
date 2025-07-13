using MyApiApp.Domain;
using MyApiApp.Application.Contracts.RiskStage;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System;

namespace MyApiApp.Application.RiskStage
{
    public class RiskStageAppService : ReadOnlyAppService<
        MyApiApp.Domain.RiskStage,
        RiskStageDto,
        Guid,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto>, IRiskStageAppService
    {
        public RiskStageAppService(IRepository<MyApiApp.Domain.RiskStage, Guid> repository)
            : base(repository)
        {
        }
    }
} 