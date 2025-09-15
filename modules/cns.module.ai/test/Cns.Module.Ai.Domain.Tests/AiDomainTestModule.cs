using Volo.Abp.Modularity;

namespace Cns.Module.Ai;

[DependsOn(
    typeof(AiDomainModule),
    typeof(AiTestBaseModule)
)]
public class AiDomainTestModule : AbpModule
{

}
