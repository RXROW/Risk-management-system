using System;
using Volo.Abp.Domain.Entities;

namespace MyApiApp.Domain
{
    public class RiskResponse : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public new Guid Id { get => base.Id; set => base.Id = value; }
    }
} 