using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp.Application.Contracts.RiskCategory
{
    public class RiskCategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 