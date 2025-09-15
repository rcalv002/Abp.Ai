using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Cns.Module.Ai.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(AiBlazorModule)
    )]
public class AiBlazorServerModule : AbpModule
{

}
