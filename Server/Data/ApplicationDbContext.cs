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

        // Tabellen 'role' fra databasen
        public DbSet<ApplicationRole> role { get; set; }

        //Tabellen 'ticket' fra databasen
        public DbSet<TicketClass> ticket { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Default tabeller fra Entity Framework
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("user_claim");
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("user_login");
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("user_role");
            modelBuilder.Entity<IdentityUserToken<string>>().ToTable("user_token");

            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("role_claim");

            modelBuilder.Entity<PersistedGrant>().ToTable("persisted_grant").HasKey(u => u.Key);
            modelBuilder.Ignore<DeviceFlowCodes>();

            // 'user'-tabel
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.ToTable("user");
                //b.Property(e => e.PasswordHash).HasColumnName("Password");
                b.Property(e => e.BirthDate).HasColumnType("date");
                b.Property(e => e.Created).HasColumnType("timestamp with time zone");
                b.Property(e => e.Modified).HasColumnType("timestamp with time zone");
            });

            // 'role'-tabel
            modelBuilder.Entity<ApplicationRole>().ToTable("role");

            // 'task'-tabel
            modelBuilder.Entity<ApplicationTask>(b =>
            {
                b.ToTable("task");
                b.Property(e => e.StartTime).HasColumnType("timestamp with time zone");
                b.Property(e => e.StopTime).HasColumnType("timestamp with time zone");
                b.Property(e => e.Created).HasColumnType("timestamp with time zone");
                b.Property(e => e.Modified).HasColumnType("timestamp with time zone");

                // Fremmednøgle på 'Volunteer' til 'Email' i user-tabellen
                b.HasOne("OpenAir.Shared.Models.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("VolunteerEmail")
                    .HasPrincipalKey("Email");
            });

            // 'ticket'-tabel
            modelBuilder.Entity<TicketClass>(b =>
            {
                b.ToTable("ticket");

                // Fremmednøgle på 'Email' til 'Email' i user-tabellen
                b.HasOne("OpenAir.Shared.Models.ApplicationUser", null)
                    .WithMany()
                    .HasForeignKey("Email")
                    .HasPrincipalKey("Email");
            });

        }

    }
}
