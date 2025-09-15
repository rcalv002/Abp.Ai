using AbpSolution3.Samples;
using Xunit;

namespace AbpSolution3.EntityFrameworkCore.Domains;

[Collection(AbpSolution3TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpSolution3EntityFrameworkCoreTestModule>
{

}
