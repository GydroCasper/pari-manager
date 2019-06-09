using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PariService.Helpers;

namespace PariService.Database
{
    public class PariDbContext: DbContext
    {
        private readonly AppSettings _settings;

        public PariDbContext(IOptions<AppSettings> options)
        {
            _settings = options.Value;
        }    

        public DbSet<Paris> Paris { get; set; }

        public DbSet<Users> Users { get; set; }

        public DbSet<Attitudes> Attitudes { get; set; }

        public DbSet<Bettors> Bettors { get; set; }

        public DbSet<Judges> Judges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(_settings.ConnectionString);
    }
}