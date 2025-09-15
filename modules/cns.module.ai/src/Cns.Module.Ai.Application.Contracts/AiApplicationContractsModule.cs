using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Cns.Module.Ai;

[DependsOn(
    typeof(AiDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class AiApplicationContractsModule : AbpModule
{

}
