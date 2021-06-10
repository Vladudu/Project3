using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect3.Models;

namespace Project3.Data
{
    public class Project3Context : DbContext
    {
        public Project3Context (DbContextOptions<Project3Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect3.Models.Magazin> Magazin { get; set; }

        public DbSet<Proiect3.Models.Angajati> Angajati { get; set; }

        public DbSet<Proiect3.Models.Comanda> Comanda { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Proiect3.Models.Magazin>().HasData(new Proiect3.Models.Magazin() { ID = new Guid("57EA92FF-5AC7-4F49-B327-08AA85AC132C"), Denumire = "Nvidia GTX1650", Specificatii = "Placa video Nvidia GTX 1650, 4GB RAM", Status = "Ultimele doua produse" });
        }
    }
}
