using MyApiApp.Domain;
using MyApiApp.Application.Contracts.RiskResponse;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System;

namespace MyApiApp.Application.RiskResponse
{
    public class RiskResponseAppService : ReadOnlyAppService<
        MyApiApp.Domain.RiskResponse,
        RiskResponseDto,
        Guid,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto>, IRiskResponseAppService
    {
        public RiskResponseAppService(IRepository<MyApiApp.Domain.RiskResponse, Guid> repository)
            : base(repository)
        {
        }
    }
} 