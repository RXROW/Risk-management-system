using Volo.Abp.Application.Services;
using System;
using MyApiApp.Application.Contracts.RiskCategory;

namespace MyApiApp.Application.RiskCategory
{
    public interface IRiskCategoryAppService : ICrudAppService<
        RiskCategoryDto,
        Guid,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto,
        CreateUpdateRiskCategoryDto>
    {
    }
} 