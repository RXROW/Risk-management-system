using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp.Application.Contracts.Risks
{
    public class RiskDto : EntityDto<Guid>
    {
        public string RiskId { get; set; }
        public string RiskName { get; set; }
        public string RiskDescription { get; set; }
        public Guid EntityId { get; set; }
        public Guid FunctionalDomainId { get; set; }
        public Guid DomainAreaId { get; set; }
        public Guid RiskCategoryId { get; set; }
        public Guid RiskResponseId { get; set; }
        public Guid RiskStageId { get; set; }
        public Guid? RiskStatementId { get; set; }
        public Guid RiskOwningGroupId { get; set; }
        public Guid? RiskOwnerId { get; set; }
        public bool IsInheritFromRiskStatement { get; set; }
        public bool IsSyncWithEntityOwner { get; set; }
        public string Cause { get; set; }
        public string Impact { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
} 