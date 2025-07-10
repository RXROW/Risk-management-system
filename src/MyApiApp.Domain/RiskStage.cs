using System;
using Volo.Abp.Domain.Entities;

namespace MyApiApp.Domain
{
    public class RiskStage : Entity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public new int Id { get => base.Id; set => base.Id = value; }
    }
} 