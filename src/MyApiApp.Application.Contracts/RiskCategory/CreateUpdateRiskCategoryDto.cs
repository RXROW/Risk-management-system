using System.ComponentModel.DataAnnotations;

namespace MyApiApp.Application.Contracts.RiskCategory
{
    public class CreateUpdateRiskCategoryDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 