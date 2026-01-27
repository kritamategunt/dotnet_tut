using helloWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;

namespace helloWorld.Data
{

    public class DataContextEF : DbContext
    {

        public DbSet<Computer>? Computer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only configure the context if it hasn't been configured yet
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=True;Trusted_Connection=false;User Id=sa;Password=SQLConnect1!;",
                    options => options.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorAppSchema");
            modelBuilder.Entity<Computer>()
            .HasKey(c => c.ComputerId);
            //.HasNoKey();
            //haskey and totable are not needed as we are using dapper for querying
            //.ToTable("Computer", "TutorAppSchema");
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Computer>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.AddingDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

    }

}