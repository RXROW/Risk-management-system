using Volo.Abp.Modularity;

namespace MyApiApp;

public abstract class MyApiAppApplicationTestBase<TStartupModule> : MyApiAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
