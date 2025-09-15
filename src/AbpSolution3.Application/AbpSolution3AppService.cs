using AbpSolution3.Localization;
using Volo.Abp.Application.Services;

namespace AbpSolution3;

/* Inherit your application services from this class.
 */
public abstract class AbpSolution3AppService : ApplicationService
{
    protected AbpSolution3AppService()
    {
        LocalizationResource = typeof(AbpSolution3Resource);
    }
}
