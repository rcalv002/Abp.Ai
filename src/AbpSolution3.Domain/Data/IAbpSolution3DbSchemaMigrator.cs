using System.Threading.Tasks;

namespace AbpSolution3.Data;

public interface IAbpSolution3DbSchemaMigrator
{
    Task MigrateAsync();
}
