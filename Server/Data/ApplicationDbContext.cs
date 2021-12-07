using IdentityServer4.EntityFramework.Entities;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OpenAir.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenAir.Server.Data
{
    public class ApplicationDbContext : KeyApiAuthorizationDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }


        // Tabellen 'user' fra databasen
        public DbSet<ApplicationUser> user { get; set; }

        // Tabellen 'task' fra databasen
        public DbSet<ApplicationTask> task { get; set; }

        // Tabellen 'task' fra databasen
        public DbSet<ApplicationRole> role { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 'user'-tabel
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("user");
                b.Property(b => b.BirthDate).HasColumnType("timestamp with time zone");
                b.Property(b => b.Created).HasColumnType("timestamp with time zone");
                b.Property(b => b.Modified).HasColumnType("timestamp with time zone");
            });

            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("user_claim");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("user_login");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("user_role");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("user_token");

            // 'role'-tabel
            modelBuilder.Entity<ApplicationRole>().ToTable("role");

            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("role_claim");

            modelBuilder.Entity<PersistedGrant>().ToTable("persisted_grant").HasKey(u => u.Key);
            modelBuilder.Entity<DeviceFlowCodes>().ToTable("device_code").HasKey(u => u.UserCode);

            // 'task'-tabel
            modelBuilder.Entity<ApplicationTask>(b =>
            {
                b.ToTable("task");
                b.Property(e => e.StartTime).HasColumnType("timestamp with time zone");
                b.Property(e => e.StopTime).HasColumnType("timestamp with time zone");
            });

        }

    }
}
