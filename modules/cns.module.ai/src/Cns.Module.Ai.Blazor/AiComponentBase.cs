using Cns.Module.Ai.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Cns.Module.Ai.Blazor;

public abstract class AiComponentBase : AbpComponentBase
{
    protected AiComponentBase()
    {
        LocalizationResource = typeof(AiResource);
    }
}