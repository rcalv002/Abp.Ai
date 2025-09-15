using Volo.Abp.Modularity;

namespace Cns.Module.Ai;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class AiDomainTestBase<TStartupModule> : AiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
