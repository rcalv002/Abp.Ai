using Localization.Resources.AbpUi;
using Cns.Module.Ai.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Cns.Module.Ai;

[DependsOn(
    typeof(AiApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class AiHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AiHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AiResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
