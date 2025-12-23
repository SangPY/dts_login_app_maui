using dts_login_app.API.Model;
using Microsoft.EntityFrameworkCore;

namespace dts_login_app.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
    }
}
