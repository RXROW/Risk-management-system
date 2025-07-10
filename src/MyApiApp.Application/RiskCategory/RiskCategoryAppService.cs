using MyApiApp.Domain;
using MyApiApp.Application.Contracts.RiskCategory;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using System;

namespace MyApiApp.Application.RiskCategory
{
    public class RiskCategoryAppService : CrudAppService<
        MyApiApp.Domain.RiskCategory,
        RiskCategoryDto,
        Guid,
        Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto,
        CreateUpdateRiskCategoryDto>, IRiskCategoryAppService
    {
        public RiskCategoryAppService(IRepository<MyApiApp.Domain.RiskCategory, Guid> repository)
            : base(repository)
        {
        }
    }
} 