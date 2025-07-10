using System;
using Volo.Abp.Application.Dtos;

namespace MyApiApp.Application.Contracts.RiskResponse
{
    public class RiskResponseDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
} 