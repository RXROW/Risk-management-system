using System;

namespace MyApiApp.Application.Contracts
{
    public class CreateUpdateDomainAreaDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid FunctionalDomainId { get; set; }
    }
} 