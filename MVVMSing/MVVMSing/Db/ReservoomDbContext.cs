using Microsoft.EntityFrameworkCore;
using MVVMSing.DTO;

namespace MVVMSing.Db
{
    internal class ReservoomDbContext : DbContext
    {
        public ReservoomDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ReservationDTO> Reservations { get; set; }
    }
}
