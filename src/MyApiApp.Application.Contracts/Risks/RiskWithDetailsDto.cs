using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp.Application.Contracts.Risks
{
    public class RiskWithDetailsDto : EntityDto<Guid>
    {
        public string RiskId { get; set; }
        public string RiskName { get; set; }
        public string RiskDescription { get; set; }
        
        // Entity details
        public Guid EntityId { get; set; }
        public string EntityName { get; set; }
        public string EntityDescription { get; set; }
        
        // Functional Domain details
        public Guid FunctionalDomainId { get; set; }
        public string FunctionalDomainName { get; set; }
        public string FunctionalDomainDescription { get; set; }
        
        // Domain Area details
        public Guid DomainAreaId { get; set; }
        public string DomainAreaName { get; set; }
        public string DomainAreaDescription { get; set; }
        
        // Risk Category details
        public Guid RiskCategoryId { get; set; }
        public string RiskCategoryName { get; set; }
        public string RiskCategoryDescription { get; set; }
        
        // Risk Response details
        public int RiskResponseId { get; set; }
        public string RiskResponseName { get; set; }
        public string RiskResponseDescription { get; set; }
        
        // Risk Stage details
        public int RiskStageId { get; set; }
        public string RiskStageName { get; set; }
        public string RiskStageDescription { get; set; }
        
        // Risk Statement details
        public Guid? RiskStatementId { get; set; }
        public string RiskStatementName { get; set; }
        public string RiskStatementDescription { get; set; }
        
        // Owning Group details
        public Guid RiskOwningGroupId { get; set; }
        public string RiskOwningGroupName { get; set; }
        
        // Risk Owner details
        public Guid? RiskOwnerId { get; set; }
        public string RiskOwnerName { get; set; }
        
        public bool IsInheritFromRiskStatement { get; set; }
        public bool IsSyncWithEntityOwner { get; set; }
        public string Cause { get; set; }
        public string Impact { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
} 