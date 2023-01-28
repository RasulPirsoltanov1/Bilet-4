using Bilet_4.Core.Entities;
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bilet_4.DataAccess.Contetxs
{

    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Feature> Features { get; set; } = null!;
        public DbSet<Setting> Settings { get; set; } = null!;
    }

}
