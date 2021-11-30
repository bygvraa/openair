using OpenAir.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace OpenAir.Server.DataAccess.Contexts
{
    public class DomainDbContext : DbContext
    {
        public DomainDbContext(DbContextOptions<DomainDbContext> options)
            : base(options)
        {
        }

        // Tabellen 'user' fra databasen
        public DbSet<UserClass> user { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
