using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Cns.Module.Ai;

[DependsOn(
    typeof(AiApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class AiHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(AiApplicationContractsModule).Assembly,
            AiRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AiHttpApiClientModule>();
        });

    }
}
