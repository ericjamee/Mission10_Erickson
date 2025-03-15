using Microsoft.EntityFrameworkCore;

namespace Mission10_Erickson.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options) : base(options)
        {
        }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure EF Core does NOT try to recreate tables that already exist
            modelBuilder.Entity<Bowler>().ToTable("Bowlers");
            modelBuilder.Entity<Team>().ToTable("Teams");
        }
    }
}
