using AbpSolution3.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpSolution3.Blazor;

public abstract class AbpSolution3ComponentBase : AbpComponentBase
{
    protected AbpSolution3ComponentBase()
    {
        LocalizationResource = typeof(AbpSolution3Resource);
    }
}
