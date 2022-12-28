using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BireCokOrnek.Data
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Departman> Departmanlar { get; set; }

        public DbSet<Calisan> Calisanlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=BireCokOrnekDb;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Calisan>().Property(x => x.Soyad).IsRequired();

            modelBuilder.Entity<Departman>().HasData(
                new Departman() { Id = 1, Ad = "Muhasebe" },
                new Departman() { Id = 2, Ad = "Bilgi İşlem" },
                new Departman() { Id = 3, Ad = "Satış ve Pazarlama" },
                new Departman() { Id = 4, Ad = "Ar-Ge" }
                );

            modelBuilder.Entity<Calisan>().HasData(
                new Calisan() { Id = 1, Ad = "Ali", Soyad = "Öz", DepartmanId = 1 },
                new Calisan() { Id = 2, Ad = "Can", Soyad = "Demir", DepartmanId = 2 },
                new Calisan() { Id = 3, Ad = "Cem", Soyad = "Kaya", DepartmanId = 2 },
                new Calisan() { Id = 4, Ad = "Ece", Soyad = "Şahin", DepartmanId = 3 }
                );
        }
    }
}
