using Volo.Abp.Modularity;

namespace Cns.Module.Ai;

[DependsOn(
    typeof(AiApplicationModule),
    typeof(AiDomainTestModule)
    )]
public class AiApplicationTestModule : AbpModule
{

}
