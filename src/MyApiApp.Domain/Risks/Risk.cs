using System;
using Volo.Abp.Domain.Entities.Auditing;

public class Risk : FullAuditedEntity<Guid>
{
    public string RiskId { get; set; }
    public string RiskName { get; set; }
    public Guid EntityId { get; set; }
    public int RiskStageId { get; set; } = 1;
    public MyApiApp.Domain.RiskStage RiskStage { get; set; }
    public bool IsInheritFromRiskStatement { get; set; }
    public Guid RiskSourceId { get; set; }
    public Guid RiskTypeId { get; set; }
    public Guid RiskCategoryId { get; set; }
    public MyApiApp.Domain.RiskCategory RiskCategory { get; set; }
    public Guid RiskSubCategoryId { get; set; }
    public Guid RiskOwnerId { get; set; }
    public Guid RiskDriverId { get; set; }
    public string Cause { get; set; }
    public string Impact { get; set; }
    public Guid InherentRiskRatingId { get; set; }
    public Guid ResidualRiskRatingId { get; set; }
    public Guid ControlEffectivenessId { get; set; }
    public int RiskResponseId { get; set; } = 1;
    public MyApiApp.Domain.RiskResponse RiskResponse { get; set; }
    // CreationTime and CreatorId are handled by FullAuditedEntity
} 