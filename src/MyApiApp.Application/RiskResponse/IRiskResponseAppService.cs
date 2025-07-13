using Volo.Abp.Application.Services;
using System;
using MyApiApp.Application.Contracts.RiskResponse;

namespace MyApiApp.Application.RiskResponse
{
    public interface IRiskResponseAppService : IReadOnlyAppService<
        RiskResponseDto,
        Guid,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto>
    {
    }
} 