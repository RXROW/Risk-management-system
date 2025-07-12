using Volo.Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using MyApiApp.Domain.Risks;

namespace MyApiApp.Domain
{
    public class Entity : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? OwnerId { get; set; }
        public ICollection<Risk> Risks { get; set; }
    }
}
