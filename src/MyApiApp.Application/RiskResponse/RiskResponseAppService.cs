using MyApiApp.Domain;
using MyApiApp.Application.Contracts.RiskResponse;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System;

namespace MyApiApp.Application.RiskResponse
{
    public class RiskResponseAppService : CrudAppService<
        MyApiApp.Domain.RiskResponse,
        RiskResponseDto,
        int,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto,
        CreateUpdateRiskResponseDto>, IRiskResponseAppService
    {
        public RiskResponseAppService(IRepository<MyApiApp.Domain.RiskResponse, int> repository)
            : base(repository)
        {
        }
    }
} 