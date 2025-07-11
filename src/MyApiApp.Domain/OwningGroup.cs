using Volo.Abp.Domain.Entities;
using System;

namespace MyApiApp.Domain
{
    public class OwningGroup : Entity<Guid>
    {
        public string Name { get; set; }

        public OwningGroup(Guid id) : base(id) { }
        public OwningGroup() { }
    }
} 