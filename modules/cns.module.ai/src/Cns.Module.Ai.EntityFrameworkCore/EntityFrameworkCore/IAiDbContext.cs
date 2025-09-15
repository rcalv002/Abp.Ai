using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cns.Module.Ai.EntityFrameworkCore;

[ConnectionStringName(AiDbProperties.ConnectionStringName)]
public interface IAiDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
