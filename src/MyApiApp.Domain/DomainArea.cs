using Volo.Abp.Domain.Entities;
using System;

namespace MyApiApp.Domain
{
    public class DomainArea : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid FunctionalDomainId { get; set; }
        public FunctionalDomain FunctionalDomain { get; set; }

        public DomainArea(Guid id) : base(id) { }
        public DomainArea() { }
    }
} 