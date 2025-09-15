using Microsoft.EntityFrameworkCore;

namespace AbpSolution3.EntityFrameworkCore;

public class AbpSolution3DbContextFactory :
    AbpSolution3DbContextFactoryBase<AbpSolution3DbContext>
{
    protected override AbpSolution3DbContext CreateDbContext(
        DbContextOptions<AbpSolution3DbContext> dbContextOptions)
    {
        return new AbpSolution3DbContext(dbContextOptions);
    }
}
