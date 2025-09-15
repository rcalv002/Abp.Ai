using Cns.Module.Ai.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Cns.Module.Ai;

public abstract class AiController : AbpControllerBase
{
    protected AiController()
    {
        LocalizationResource = typeof(AiResource);
    }
}
