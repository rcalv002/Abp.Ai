using AbpSolution3.Samples;
using Xunit;

namespace AbpSolution3.EntityFrameworkCore.Applications;

[Collection(AbpSolution3TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpSolution3EntityFrameworkCoreTestModule>
{

}
