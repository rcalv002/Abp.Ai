using Microsoft.EntityFrameworkCore;

namespace AbpSolution3.EntityFrameworkCore;

public class AbpSolution3TenantDbContextFactory :
    AbpSolution3DbContextFactoryBase<AbpSolution3TenantDbContext>
{
    public AbpSolution3TenantDbContextFactory()
        : base("TenantDevelopmentTime")
    {

    }

    protected override AbpSolution3TenantDbContext CreateDbContext(
        DbContextOptions<AbpSolution3TenantDbContext> dbContextOptions)
    {
        return new AbpSolution3TenantDbContext(dbContextOptions);
    }
}
