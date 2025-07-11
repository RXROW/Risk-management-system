using Volo.Abp.Domain.Entities;
using System;

namespace MyApiApp.Domain
{
    public class RiskStatement : Entity<Guid>
    {
        public string Statement { get; set; }
        public DateTime? CreatedDate { get; set; }

        public RiskStatement(Guid id) : base(id) { }
        public RiskStatement() { }
    }
} 