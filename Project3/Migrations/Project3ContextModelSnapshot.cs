﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project3.Data;

namespace Project3.Migrations
{
    [DbContext(typeof(Project3Context))]
    partial class Project3ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proiect3.Models.Angajati", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salar")
                        .HasColumnType("int");

                    b.Property<string>("Vechime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Angajati");
                });

            modelBuilder.Entity("Proiect3.Models.Comanda", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdresaPentruLivrare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Continut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataComenzii")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPret")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("Proiect3.Models.Magazin", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pret")
                        .HasColumnType("int");

                    b.Property<string>("Specificatii")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Magazin");

                    b.HasData(
                        new
                        {
                            ID = new Guid("57ea92ff-5ac7-4f49-b327-08aa85ac132c"),
                            Denumire = "Nvidia GTX1650",
                            Pret = 0,
                            Specificatii = "Placa video Nvidia GTX 1650, 4GB RAM",
                            Status = "Ultimele doua produse"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}