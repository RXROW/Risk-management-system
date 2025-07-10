using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Microsoft.Extensions.DependencyInjection;

namespace MyApiApp;

[DependsOn(
    typeof(MyApiAppDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(MyApiAppApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class MyApiAppApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<MyApiAppApplicationModule>();
        });

        context.Services.AddTransient<MyApiApp.Categories.CategoryAppService>();
        context.Services.AddTransient<MyApiApp.Application.RiskCategory.RiskCategoryAppService>();
        context.Services.AddTransient<MyApiApp.Application.RiskStage.RiskStageAppService>();
        context.Services.AddTransient<MyApiApp.Application.RiskResponse.RiskResponseAppService>();
    }
}
