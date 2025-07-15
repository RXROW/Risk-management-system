using System;

namespace MyApiApp.Application.Contracts
{
    public class RiskStatementDto
    {
        public Guid Id { get; set; }
        public string Statement { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
} 