using Microsoft.Extensions.Localization;
using AbpSolution3.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpSolution3.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpSolution3BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpSolution3Resource> _localizer;

    public AbpSolution3BrandingProvider(IStringLocalizer<AbpSolution3Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
