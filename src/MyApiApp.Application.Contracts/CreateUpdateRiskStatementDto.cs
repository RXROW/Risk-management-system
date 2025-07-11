using System;

namespace MyApiApp.Application.Contracts
{
    public class CreateUpdateRiskStatementDto
    {
        public string Statement { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
} 