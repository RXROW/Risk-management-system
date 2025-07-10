using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp.Risks
{
    public class RiskDto : EntityDto<Guid>
    {
        public string RiskId { get; set; }
        public string RiskName { get; set; }
        public Guid EntityId { get; set; }
        public Guid RiskStageId { get; set; }
        public bool IsInheritFromRiskStatement { get; set; }
        public Guid RiskSourceId { get; set; }
        public Guid RiskTypeId { get; set; }
        public Guid RiskCategoryId { get; set; }
        public Guid RiskSubCategoryId { get; set; }
        public Guid RiskOwnerId { get; set; }
        public Guid RiskDriverId { get; set; }
        public string Cause { get; set; }
        public string Impact { get; set; }
        public Guid InherentRiskRatingId { get; set; }
        public Guid ResidualRiskRatingId { get; set; }
        public Guid ControlEffectivenessId { get; set; }
    }
} 