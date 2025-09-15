using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace AbpSolution3.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class AbpSolution3TenantDbContext : AbpSolution3DbContextBase<AbpSolution3TenantDbContext>
{
    public AbpSolution3TenantDbContext(DbContextOptions<AbpSolution3TenantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Tenant);

        base.OnModelCreating(builder);
    }
}
