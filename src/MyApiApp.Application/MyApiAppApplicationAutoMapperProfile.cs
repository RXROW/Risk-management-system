using AutoMapper;
using ABPCourse.Demo1.Categories;
using MyApiApp.Categories;
using MyApiApp.Domain.Risks;
using MyApiApp.Application.Contracts.Risks;

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
        
        // Risk with details mapping
        CreateMap<Risk, RiskWithDetailsDto>()
            .ForMember(dest => dest.EntityName, opt => opt.MapFrom(src => src.Entity != null ? src.Entity.Name : null))
            .ForMember(dest => dest.EntityDescription, opt => opt.MapFrom(src => src.Entity != null ? src.Entity.Description : null))
            .ForMember(dest => dest.FunctionalDomainName, opt => opt.MapFrom(src => src.FunctionalDomain != null ? src.FunctionalDomain.Name : null))
            .ForMember(dest => dest.FunctionalDomainDescription, opt => opt.MapFrom(src => src.FunctionalDomain != null ? src.FunctionalDomain.Description : null))
            .ForMember(dest => dest.DomainAreaName, opt => opt.MapFrom(src => src.DomainArea != null ? src.DomainArea.Name : null))
            .ForMember(dest => dest.DomainAreaDescription, opt => opt.MapFrom(src => src.DomainArea != null ? src.DomainArea.Description : null))
            .ForMember(dest => dest.RiskCategoryName, opt => opt.MapFrom(src => src.RiskCategory != null ? src.RiskCategory.Name : null))
            .ForMember(dest => dest.RiskCategoryDescription, opt => opt.MapFrom(src => src.RiskCategory != null ? src.RiskCategory.Description : null))
            .ForMember(dest => dest.RiskResponseName, opt => opt.MapFrom(src => src.RiskResponse != null ? src.RiskResponse.Name : null))
            .ForMember(dest => dest.RiskResponseDescription, opt => opt.MapFrom(src => src.RiskResponse != null ? src.RiskResponse.Description : null))
            .ForMember(dest => dest.RiskStageName, opt => opt.MapFrom(src => src.RiskStage != null ? src.RiskStage.Name : null))
            .ForMember(dest => dest.RiskStageDescription, opt => opt.MapFrom(src => src.RiskStage != null ? src.RiskStage.Description : null))
            .ForMember(dest => dest.RiskStatementName, opt => opt.MapFrom(src => src.RiskStatement != null ? src.RiskStatement.Statement : null))
            .ForMember(dest => dest.RiskStatementDescription, opt => opt.MapFrom(src => src.RiskStatement != null ? src.RiskStatement.Statement : null))
            .ForMember(dest => dest.RiskOwningGroupName, opt => opt.MapFrom(src => src.RiskOwningGroup != null ? src.RiskOwningGroup.Name : null));
        
        CreateMap<MyApiApp.Domain.RiskCategory, MyApiApp.Application.Contracts.RiskCategory.RiskCategoryDto>();
        CreateMap<MyApiApp.Application.Contracts.RiskCategory.CreateUpdateRiskCategoryDto, MyApiApp.Domain.RiskCategory>();
        CreateMap<MyApiApp.Domain.RiskStage, MyApiApp.Application.Contracts.RiskStage.RiskStageDto>();
        CreateMap<MyApiApp.Application.Contracts.RiskStage.CreateUpdateRiskStageDto, MyApiApp.Domain.RiskStage>();
        CreateMap<MyApiApp.Domain.RiskResponse, MyApiApp.Application.Contracts.RiskResponse.RiskResponseDto>();
        CreateMap<MyApiApp.Application.Contracts.RiskResponse.CreateUpdateRiskResponseDto, MyApiApp.Domain.RiskResponse>();
        CreateMap<MyApiApp.Domain.Entity, EntityDto>();
        CreateMap<CreateUpdateEntityDto, MyApiApp.Domain.Entity>();
    }
}
