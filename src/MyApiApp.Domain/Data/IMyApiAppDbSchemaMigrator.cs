using System.Threading.Tasks;

namespace MyApiApp.Data;

public interface IMyApiAppDbSchemaMigrator
{
    Task MigrateAsync();
}
