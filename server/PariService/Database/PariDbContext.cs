using Microsoft.EntityFrameworkCore;

namespace PariService.Database
{
    public class PariDbContext: DbContext
    {
        public DbSet<Paris> Paris { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Attitudes> Attitudes { get; set; }

        public DbSet<Bettors> Bettors { get; set; }

        public DbSet<Judges> Judges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=parimandb.cimx3cbla6j6.us-east-1.rds.amazonaws.com;Database=parimandb;Username=parimandbadmin;Password=venKolumad17");
    }
}