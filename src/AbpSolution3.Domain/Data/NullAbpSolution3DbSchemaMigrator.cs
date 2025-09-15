using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpSolution3.Data;

/* This is used if database provider does't define
 * IAbpSolution3DbSchemaMigrator implementation.
 */
public class NullAbpSolution3DbSchemaMigrator : IAbpSolution3DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
