using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Cns.Module.Ai.EntityFrameworkCore;

[ConnectionStringName(AiDbProperties.ConnectionStringName)]
public class AiDbContext : AbpDbContext<AiDbContext>, IAiDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public AiDbContext(DbContextOptions<AiDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAi();
    }
}
