using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infranstructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Description = "This is a description of Royal Villa",
                    Price = 200,
                    Sqft = 500,
                    Occupancy = 2,
                    ImageUrl = "https://example.com/royal-villa.jpg"
                   
                },
                new Villa
                {
                    Id = 2,
                    Name = "Luxury Villa",
                    Description = "This is a description of Luxury Villa",
                    Price = 300,
                    Sqft = 700,
                    Occupancy = 4,
                    ImageUrl = "https://example.com/luxury-villa.jpg"
                   
                },
                new Villa
                {
                    Id = 3,
                    Name = "Beachfront Villa",
                    Description = "This is a description of Beachfront Villa",
                    Price = 400,
                    Sqft = 900,
                    Occupancy = 6,
                    ImageUrl = "https://example.com/beachfront-villa.jpg"
                   
                }


                );
        }

    }
}
