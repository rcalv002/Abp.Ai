using AbpSolution3.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpSolution3.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpSolution3Controller : AbpControllerBase
{
    protected AbpSolution3Controller()
    {
        LocalizationResource = typeof(AbpSolution3Resource);
    }
}
