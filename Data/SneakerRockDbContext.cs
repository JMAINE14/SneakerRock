using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SneakerRockMVC.Models;

namespace SneakerRockMVC.Data
{

    public class SneakerRockDbContext : DbContext
    {
        public DbSet<Sneaker> Sneakers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandName> BrandNames { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<ColorWay> Colorways { get; set; }
        public DbSet<Collection> Collections { get; set; }

        public SneakerRockDbContext(DbContextOptions<SneakerRockDbContext> options)
            : base(options)
        { }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ColorWay>()
                .HasOptional<>()
                .WithMany()
                .WillCascadeOnDelete(false)
        }*/
    }
}
