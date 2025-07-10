using MyApiApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyApiApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyApiAppEntityFrameworkCoreModule),
    typeof(MyApiAppApplicationContractsModule)
    )]
public class MyApiAppDbMigratorModule : AbpModule
{
}
