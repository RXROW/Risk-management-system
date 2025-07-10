using AutoMapper;
using ABPCourse.Demo1.Categories;
using MyApiApp.Categories;
using MyApiApp.Risks;

namespace MyApiApp;

public class MyApiAppApplicationAutoMapperProfile : Profile
{
    public MyApiAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();
        CreateMap<Risk, RiskDto>();
        CreateMap<CreateUpdateRiskDto, Risk>();
        CreateMap<MyApiApp.Domain.RiskCategory, MyApiApp.Application.Contracts.RiskCategory.RiskCategoryDto>();
        CreateMap<MyApiApp.Application.Contracts.RiskCategory.CreateUpdateRiskCategoryDto, MyApiApp.Domain.RiskCategory>();
        CreateMap<MyApiApp.Domain.RiskStage, MyApiApp.Application.Contracts.RiskStage.RiskStageDto>();
        CreateMap<MyApiApp.Application.Contracts.RiskStage.CreateUpdateRiskStageDto, MyApiApp.Domain.RiskStage>();
        CreateMap<MyApiApp.Domain.RiskResponse, MyApiApp.Application.Contracts.RiskResponse.RiskResponseDto>();
        CreateMap<MyApiApp.Application.Contracts.RiskResponse.CreateUpdateRiskResponseDto, MyApiApp.Domain.RiskResponse>();
    }
}
