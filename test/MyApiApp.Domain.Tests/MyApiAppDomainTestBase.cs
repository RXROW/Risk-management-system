using Volo.Abp.Modularity;

namespace MyApiApp;

/* Inherit from this class for your domain layer tests. */
public abstract class MyApiAppDomainTestBase<TStartupModule> : MyApiAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
