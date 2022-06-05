using Microsoft.EntityFrameworkCore;
using MotoGP.Models;

namespace MotoGP.Data
{
    public class GPContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Rider> Riders { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Country> Countries { get; set; }

        public GPContext(DbContextOptions<GPContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<Rider>().ToTable("Rider");
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Country>().ToTable("Country");
        }
    }
}
