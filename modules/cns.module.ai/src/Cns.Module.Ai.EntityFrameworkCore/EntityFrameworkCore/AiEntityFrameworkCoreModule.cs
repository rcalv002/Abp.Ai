using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Cns.Module.Ai.EntityFrameworkCore;

[DependsOn(
    typeof(AiDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class AiEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<AiDbContext>(options =>
        {
            options.AddDefaultRepositories<IAiDbContext>(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
            * options.AddRepository<Question, EfCoreQuestionRepository>();
            */
        });
    }
}
