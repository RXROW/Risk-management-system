using System;
using Volo.Abp.Domain.Entities;

namespace MyApiApp.Domain
{
    public class FunctionalDomain : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public FunctionalDomain(Guid id) : base(id) { }
        public FunctionalDomain() { }
    }
} 