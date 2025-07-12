using AutoMapper;
using MyApiApp.Application.Dtos;
using MyApiApp.Domain;

namespace MyApiApp.Application.AutoMapperProfiles
{
    public class MyApiAppApplicationAutoMapperProfile : Profile
    {
        public MyApiAppApplicationAutoMapperProfile()
        {
            CreateMap<Risk, RiskDto>()
                .ForMember(dest => dest.RiskStageId, opt => opt.MapFrom(src => src.RiskStageId))
                .ForMember(dest => dest.RiskResponseId, opt => opt.MapFrom(src => src.RiskResponseId))
                .ForMember(dest => dest.RiskDescription, opt => opt.MapFrom(src => src.RiskDescription))
                .ForMember(dest => dest.FunctionalDomainId, opt => opt.MapFrom(src => src.FunctionalDomainId))
                .ForMember(dest => dest.DomainAreaId, opt => opt.MapFrom(src => src.DomainAreaId))
                .ForMember(dest => dest.RiskCategoryId, opt => opt.MapFrom(src => src.RiskCategoryId))
                .ForMember(dest => dest.RiskStatementId, opt => opt.MapFrom(src => src.RiskStatementId))
                .ForMember(dest => dest.RiskOwningGroupId, opt => opt.MapFrom(src => src.RiskOwningGroupId))
                .ForMember(dest => dest.RiskOwnerId, opt => opt.MapFrom(src => src.RiskOwnerId))
                .ForMember(dest => dest.IsInheritFromRiskStatement, opt => opt.MapFrom(src => src.IsInheritFromRiskStatement))
                .ForMember(dest => dest.IsSyncWithEntityOwner, opt => opt.MapFrom(src => src.IsSyncWithEntityOwner))
                .ForMember(dest => dest.Cause, opt => opt.MapFrom(src => src.Cause))
                .ForMember(dest => dest.Impact, opt => opt.MapFrom(src => src.Impact))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));
            CreateMap<CreateUpdateRiskDto, Risk>()
                .ForMember(dest => dest.RiskStageId, opt => opt.MapFrom(src => src.RiskStageId))
                .ForMember(dest => dest.RiskResponseId, opt => opt.MapFrom(src => src.RiskResponseId))
                .ForMember(dest => dest.RiskDescription, opt => opt.MapFrom(src => src.RiskDescription))
                .ForMember(dest => dest.FunctionalDomainId, opt => opt.MapFrom(src => src.FunctionalDomainId))
                .ForMember(dest => dest.DomainAreaId, opt => opt.MapFrom(src => src.DomainAreaId))
                .ForMember(dest => dest.RiskCategoryId, opt => opt.MapFrom(src => src.RiskCategoryId))
                .ForMember(dest => dest.RiskStatementId, opt => opt.MapFrom(src => src.RiskStatementId))
                .ForMember(dest => dest.RiskOwningGroupId, opt => opt.MapFrom(src => src.RiskOwningGroupId))
                .ForMember(dest => dest.RiskOwnerId, opt => opt.MapFrom(src => src.RiskOwnerId))
                .ForMember(dest => dest.IsInheritFromRiskStatement, opt => opt.MapFrom(src => src.IsInheritFromRiskStatement))
                .ForMember(dest => dest.IsSyncWithEntityOwner, opt => opt.MapFrom(src => src.IsSyncWithEntityOwner))
                .ForMember(dest => dest.Cause, opt => opt.MapFrom(src => src.Cause))
                .ForMember(dest => dest.Impact, opt => opt.MapFrom(src => src.Impact))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status));
        }
    }
} 