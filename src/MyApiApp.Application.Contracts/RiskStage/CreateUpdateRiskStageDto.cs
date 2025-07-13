using System;
using System.ComponentModel.DataAnnotations;

namespace MyApiApp.Application.Contracts.RiskStage
{
    public class CreateUpdateRiskStageDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 