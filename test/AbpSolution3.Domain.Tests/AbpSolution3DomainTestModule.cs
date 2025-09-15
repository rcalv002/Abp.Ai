using Volo.Abp.Modularity;

namespace AbpSolution3;

[DependsOn(
    typeof(AbpSolution3DomainModule),
    typeof(AbpSolution3TestBaseModule)
)]
public class AbpSolution3DomainTestModule : AbpModule
{

}
