using helloWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;

namespace helloWorld.Data
{

    public class DataContextEF : DbContext
    {
        private readonly IConfiguration _config;

        public DataContextEF(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Computer>? Computer { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only configure the context if it hasn't been configured yet
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
                    options => options.EnableRetryOnFailure()
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorAppSchema");
            modelBuilder.Entity<Computer>(entity =>
            {
                entity.HasKey(c => c.ComputerId);
                entity.ToTable("Computer");

                // Configure EF to use property access mode for properties with private setters
                entity.Property(c => c.ComputerId)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.Motherboard)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.CPUCores)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.HasWifi)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.HasLTE)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.ReleaseDate)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.Price)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.VideoCard)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
                entity.Property(c => c.AddingDate)
                    .UsePropertyAccessMode(PropertyAccessMode.Property);
            });
        }
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Computer>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("AddingDate").CurrentValue = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }

    }

}