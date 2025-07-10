using Volo.Abp.Application.Services;
using System;
using MyApiApp.Application.Contracts.RiskResponse;

namespace MyApiApp.Application.RiskResponse
{
    public interface IRiskResponseAppService : ICrudAppService<
        RiskResponseDto,
        int,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto,
        CreateUpdateRiskResponseDto>
    {
    }
} 