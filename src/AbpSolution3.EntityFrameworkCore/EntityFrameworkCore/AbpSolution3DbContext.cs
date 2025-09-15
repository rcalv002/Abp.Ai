using Cns.Module.Ai.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace AbpSolution3.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class AbpSolution3DbContext : AbpSolution3DbContextBase<AbpSolution3DbContext>
{
    public AbpSolution3DbContext(DbContextOptions<AbpSolution3DbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Both);

        base.OnModelCreating(builder);

        builder.ConfigureAi();
    }
}
