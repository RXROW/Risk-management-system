using System;
using Volo.Abp.Domain.Entities;

namespace MyApiApp.Domain
{
    public class RiskCategory : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public new Guid Id { get => base.Id; set => base.Id = value; }

        public RiskCategory() { }
        public RiskCategory(Guid id, string name, string description)
            : base(id)
        {
            Name = name;
            Description = description;
        }
    }
} 