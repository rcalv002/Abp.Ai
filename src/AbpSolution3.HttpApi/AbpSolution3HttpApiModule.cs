using Cns.Module.Ai;
using Localization.Resources.AbpUi;
using AbpSolution3.Localization;
using Volo.Abp.Account;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.LanguageManagement;
using Volo.Saas.Host;
using Volo.Abp.TextTemplateManagement;
using Volo.Abp.Gdpr;
using Volo.Abp.OpenIddict;
using Volo.Abp.LeptonXTheme.Management;

namespace AbpSolution3;

 [DependsOn(
    typeof(AiHttpApiModule),
    typeof(AbpSolution3ApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpAccountAdminHttpApiModule),
    typeof(TextTemplateManagementHttpApiModule),
    typeof(AbpAuditLoggingHttpApiModule),
    typeof(AbpOpenIddictProHttpApiModule),
    typeof(LanguageManagementHttpApiModule),
    typeof(SaasHostHttpApiModule),
    typeof(AbpGdprHttpApiModule),
    typeof(AbpAccountPublicHttpApiModule),
    typeof(LeptonXThemeManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule)
    )]
public class AbpSolution3HttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpSolution3Resource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
