using System.ComponentModel.DataAnnotations;

namespace MyApiApp.Application.Contracts.RiskResponse
{
    public class CreateUpdateRiskResponseDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 