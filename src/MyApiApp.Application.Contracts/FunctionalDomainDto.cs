using System;

namespace MyApiApp.Application.Contracts
{
    public class FunctionalDomainDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 