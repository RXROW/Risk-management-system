using Volo.Abp.Application.Services;
using System;
using MyApiApp.Application.Contracts.RiskStage;

namespace MyApiApp.Application.RiskStage
{
    public interface IRiskStageAppService : IReadOnlyAppService<
        RiskStageDto,
        int,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto>
    {
    }
} 