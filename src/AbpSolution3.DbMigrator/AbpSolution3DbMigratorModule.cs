using AbpSolution3.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpSolution3.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpSolution3EntityFrameworkCoreModule),
    typeof(AbpSolution3ApplicationContractsModule)
)]
public class AbpSolution3DbMigratorModule : AbpModule
{
}
