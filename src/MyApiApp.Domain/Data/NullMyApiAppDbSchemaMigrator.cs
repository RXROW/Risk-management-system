using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyApiApp.Data;

/* This is used if database provider does't define
 * IMyApiAppDbSchemaMigrator implementation.
 */
public class NullMyApiAppDbSchemaMigrator : IMyApiAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
