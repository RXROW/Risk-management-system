using System;
using MyApiApp.Domain.Shared;

namespace MyApiApp.Application.Contracts
{
    public class CreateUpdateRiskAssessmentDto
    {
        public DateTime AssessmentDate { get; set; }
        public LikelihoodLevel LikelihoodLevel { get; set; }
        public ImpactLevel ImpactLevel { get; set; }
        public OverallRating OverallRating { get; set; }
        public Guid? AssessedById { get; set; }
        public Guid RiskId { get; set; }
    }
} 