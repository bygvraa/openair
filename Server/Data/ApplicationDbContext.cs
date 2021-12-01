using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OpenAir.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAir.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        // Tabellen 'user' fra databasen
        public DbSet<ApplicationUser> user { get; set; }

        // Tabellen 'task' fra databasen
        public DbSet<TaskClass> task { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>().ToTable("user");
            //modelBuilder.Entity<ApplicationUser>().ToTable("user").Property(p => p.Id).HasColumnName("id");
            //modelBuilder.Entity<ApplicationUser>().ToTable("user").Property(p => p.Email).HasColumnName("email");
            //modelBuilder.Entity<ApplicationUser>().ToTable("user").Property(p => p.UserName).HasColumnName("username");
            //modelBuilder.Entity<ApplicationUser>().ToTable("user").Property(p => p.PasswordHash).HasColumnName("password");

            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("user_role");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("user_login");
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("user_claim");
            modelBuilder.Entity<IdentityRole>().ToTable("role");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("role_claim");
            modelBuilder.Entity<PersistedGrant>().ToTable("persisted_grant");
            modelBuilder.Entity<DeviceFlowCodes>().ToTable("device_code");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("user_token");

        }
    }
}
