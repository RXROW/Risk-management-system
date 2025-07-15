using Volo.Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyApiApp.Domain.Risks;

namespace MyApiApp.Domain
{
    public class Entity : FullAuditedEntity<Guid>
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        
        public Guid? OwnerId { get; set; }
        public ICollection<Risk> Risks { get; set; }
    }
}
