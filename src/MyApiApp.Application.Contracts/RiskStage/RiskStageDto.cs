using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp.Application.Contracts.RiskStage
{
    public class RiskStageDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 