using System;

namespace MyApiApp.Application.Contracts
{
    public class DomainAreaDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid FunctionalDomainId { get; set; }
        public string FunctionalDomainName { get; set; }
    }
} 