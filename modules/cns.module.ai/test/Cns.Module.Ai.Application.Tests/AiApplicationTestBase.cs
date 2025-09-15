using Volo.Abp.Modularity;

namespace Cns.Module.Ai;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class AiApplicationTestBase<TStartupModule> : AiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
