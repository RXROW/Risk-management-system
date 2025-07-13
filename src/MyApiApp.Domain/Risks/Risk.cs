using System;
using Volo.Abp.Domain.Entities.Auditing;
using MyApiApp.Domain;

namespace MyApiApp.Domain.Risks
{
    public class Risk : FullAuditedEntity<Guid>
    {
        public string RiskId { get; set; }
        public string RiskName { get; set; }
        public string RiskDescription { get; set; }
        public Guid EntityId { get; set; }
        public Entity Entity { get; set; }
        public Guid FunctionalDomainId { get; set; }
        public FunctionalDomain FunctionalDomain { get; set; }
        public Guid DomainAreaId { get; set; }
        public DomainArea DomainArea { get; set; }
        public Guid RiskCategoryId { get; set; }
        public RiskCategory RiskCategory { get; set; }
        public Guid RiskResponseId { get; set; }
        public RiskResponse RiskResponse { get; set; }
        public Guid RiskStageId { get; set; }
        public RiskStage RiskStage { get; set; }
        public Guid? RiskStatementId { get; set; }
        public RiskStatement RiskStatement { get; set; }
        public Guid RiskOwningGroupId { get; set; }
        public OwningGroup RiskOwningGroup { get; set; }
        public Guid? RiskOwnerId { get; set; }
        public bool IsInheritFromRiskStatement { get; set; }
        public bool IsSyncWithEntityOwner { get; set; }
        public string Cause { get; set; }
        public string Impact { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
} 