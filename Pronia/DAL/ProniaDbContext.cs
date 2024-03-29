﻿using Microsoft.EntityFrameworkCore;
using Pronia.Entities;

namespace Pronia.DAL
{
    public class ProniaDbContext:DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options):base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PlantDeliveryInformation> PlantDeliveryInformation { get; set; }
        public DbSet<PlantImage> PlantImages { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>()
                .HasIndex(s => s.Key)
                .IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            base.OnModelCreating(modelBuilder);
        }


    }
}
