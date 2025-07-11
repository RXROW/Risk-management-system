using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp
{
    public class CreateUpdateEntityDto : IEntityDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? OwnerId { get; set; }
    }
}
