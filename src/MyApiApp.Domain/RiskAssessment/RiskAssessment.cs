using Volo.Abp.Domain.Entities;
using System;
using MyApiApp.Domain.Shared;
using MyApiApp.Domain.Risks;

namespace MyApiApp.Domain
{
    public class RiskAssessment : Entity<Guid>
    {
        public DateTime AssessmentDate { get; set; }
        public LikelihoodLevel LikelihoodLevel { get; set; }
        public ImpactLevel ImpactLevel { get; set; }
        public OverallRating OverallRating { get; set; }
        public Guid? AssessedById { get; set; }
        public Guid RiskId { get; set; }
        public Risk Risk { get; set; }

        public RiskAssessment(Guid id) : base(id) { }
        public RiskAssessment() { }
    }
} 