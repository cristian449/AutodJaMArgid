using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutodJaMargid
{
    public class CarsContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite
            ("Data Source=Cars.db");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandID = 1, BrandName = "Audi" },
                new Brand { BrandID = 2, BrandName = "BMW" },
                new Brand { BrandID = 3, BrandName = "Ford" },
                new Brand { BrandID = 4, BrandName = "Honda" },
                new Brand { BrandID = 5, BrandName = "Hyundai" },
                new Brand { BrandID = 6, BrandName = "Nissan" },
                new Brand { BrandID = 7, BrandName = "Toyota" }
                );

            modelBuilder.Entity<Car>().HasData(
                new Car { CarID = 1, BrandID = 1, CarName = "A8" },
                new Car { CarID = 2, BrandID = 1, CarName = "Q7" },
                new Car { CarID = 3, BrandID = 1, CarName = "Q5" },
                new Car { CarID = 4, BrandID = 1, CarName = "Q7" },
                new Car { CarID = 5, BrandID = 1, CarName = "Etron" },
                new Car { CarID = 6, BrandID = 1, CarName = "A4" },
                new Car { CarID = 7, BrandID = 1, CarName = "R8" },
                new Car { CarID = 8, BrandID = 1, CarName = "S5" },
                new Car { CarID = 9, BrandID = 1, CarName = "Q2" },
                new Car { CarID = 10, BrandID = 2, CarName = "X1" },
                new Car { CarID = 11, BrandID = 2, CarName = "X2" },
                new Car { CarID = 12, BrandID = 2, CarName = "X3" },
                new Car { CarID = 13, BrandID = 2, CarName = "X4" },
                new Car { CarID = 14, BrandID = 2, CarName = "X5" },
                new Car { CarID = 15, BrandID = 2, CarName = "X6" },
                new Car { CarID = 16, BrandID = 2, CarName = "X7" },
                new Car { CarID = 17, BrandID = 2, CarName = "iX1" },
                new Car { CarID = 18, BrandID = 2, CarName = "XM" },
                new Car { CarID = 19, BrandID = 3, CarName = "Mustang" },
                new Car { CarID = 20, BrandID = 3, CarName = "Bronco" },
                new Car { CarID = 21, BrandID = 3, CarName = "Kuga" },
                new Car { CarID = 22, BrandID = 3, CarName = "Escape" },
                new Car { CarID = 23, BrandID = 3, CarName = "Everest" },
                new Car { CarID = 24, BrandID = 4, CarName = "TypeR" },
                new Car { CarID = 25, BrandID = 4, CarName = "Cibic" },
                new Car { CarID = 26, BrandID = 4, CarName = "City" },
                new Car { CarID = 27, BrandID = 4, CarName = "Element" },
                new Car { CarID = 28, BrandID = 5, CarName = "Tucson" },
                new Car { CarID = 29, BrandID = 5, CarName = "I20" },
                new Car { CarID = 30, BrandID = 5, CarName = "SantaFe" },
                new Car { CarID = 31, BrandID = 5, CarName = "I10" },
                new Car { CarID = 32, BrandID = 5, CarName = "Sonata" },
                new Car { CarID = 33, BrandID = 6, CarName = "Ariya" },
                new Car { CarID = 34, BrandID = 6, CarName = "Juke" },
                new Car { CarID = 35, BrandID = 6, CarName = "Sentra" },
                new Car { CarID = 36, BrandID = 6, CarName = "Kicks" },
                new Car { CarID = 37, BrandID = 6, CarName = "Murano" },
                new Car { CarID = 38, BrandID = 6, CarName = "Titan" },
                new Car { CarID = 39, BrandID = 7, CarName = "HighLander" },
                new Car { CarID = 40, BrandID = 7, CarName = "Camry" },
                new Car { CarID = 41, BrandID = 7, CarName = "GR86" },
                new Car { CarID = 42, BrandID = 7, CarName = "Rav4" }
            );

        }
    }
}
