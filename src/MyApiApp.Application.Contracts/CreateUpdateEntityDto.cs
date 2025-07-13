using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;

namespace MyApiApp
{
    public class CreateUpdateEntityDto : IEntityDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(1000)]
        public string Description { get; set; }
        
        public Guid? OwnerId { get; set; }
    }
}
