using Volo.Abp.Modularity;

namespace MyApiApp;

[DependsOn(
    typeof(MyApiAppApplicationModule),
    typeof(MyApiAppDomainTestModule)
)]
public class MyApiAppApplicationTestModule : AbpModule
{

}
