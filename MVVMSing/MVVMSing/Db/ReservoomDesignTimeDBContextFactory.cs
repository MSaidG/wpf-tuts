using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MVVMSing.Db
{
    internal class ReservoomDesignTimeDBContextFactory : IDesignTimeDbContextFactory<ReservoomDbContext>
    {
        public ReservoomDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source=reservoom.db").Options;

            return new ReservoomDbContext(options);
        }
    }
}
