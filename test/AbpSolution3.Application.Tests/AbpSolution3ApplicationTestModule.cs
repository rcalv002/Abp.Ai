using Volo.Abp.Modularity;

namespace AbpSolution3;

[DependsOn(
    typeof(AbpSolution3ApplicationModule),
    typeof(AbpSolution3DomainTestModule)
)]
public class AbpSolution3ApplicationTestModule : AbpModule
{

}
