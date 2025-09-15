using Cns.Module.Ai.Localization;
using Volo.Abp.Application.Services;

namespace Cns.Module.Ai;

public abstract class AiAppService : ApplicationService
{
    protected AiAppService()
    {
        LocalizationResource = typeof(AiResource);
        ObjectMapperContext = typeof(AiApplicationModule);
    }
}
