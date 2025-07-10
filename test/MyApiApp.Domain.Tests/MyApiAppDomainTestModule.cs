using Volo.Abp.Modularity;

namespace MyApiApp;

[DependsOn(
    typeof(MyApiAppDomainModule),
    typeof(MyApiAppTestBaseModule)
)]
public class MyApiAppDomainTestModule : AbpModule
{

}
