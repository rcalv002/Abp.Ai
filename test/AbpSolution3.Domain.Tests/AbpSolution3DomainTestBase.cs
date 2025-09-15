using Volo.Abp.Modularity;

namespace AbpSolution3;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpSolution3DomainTestBase<TStartupModule> : AbpSolution3TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
