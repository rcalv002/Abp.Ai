using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Cns.Module.Ai;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class AiInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AiInstallerModule>();
        });
    }
}
