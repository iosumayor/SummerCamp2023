﻿// <auto-generated />
using System;
using BaseDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaseDatos.Migrations
{
    [DbContext(typeof(ContextoAgenda))]
    [Migration("20230914064045_nueva_migracion3")]
    partial class nueva_migracion3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entidades_BBDD.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Persona");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FechaNacimiento = new DateTime(1990, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Juan",
                            Telefono = "987654321"
                        },
                        new
                        {
                            Id = 2,
                            FechaNacimiento = new DateTime(1985, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Maria",
                            Telefono = "123456789"
                        },
                        new
                        {
                            Id = 3,
                            FechaNacimiento = new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Pedro",
                            Telefono = "555555555"
                        },
                        new
                        {
                            Id = 4,
                            FechaNacimiento = new DateTime(1982, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Luisa",
                            Telefono = "777777777"
                        },
                        new
                        {
                            Id = 5,
                            FechaNacimiento = new DateTime(1995, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carlos",
                            Telefono = "999999999"
                        },
                        new
                        {
                            Id = 6,
                            FechaNacimiento = new DateTime(1998, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ana",
                            Telefono = "111111111"
                        },
                        new
                        {
                            Id = 7,
                            FechaNacimiento = new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Diego",
                            Telefono = "222222222"
                        },
                        new
                        {
                            Id = 8,
                            FechaNacimiento = new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Laura",
                            Telefono = "333333333"
                        },
                        new
                        {
                            Id = 9,
                            FechaNacimiento = new DateTime(1987, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Sergio",
                            Telefono = "444444444"
                        },
                        new
                        {
                            Id = 10,
                            FechaNacimiento = new DateTime(2002, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Elena",
                            Telefono = "666666666"
                        },
                        new
                        {
                            Id = 11,
                            FechaNacimiento = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Ricardo",
                            Telefono = "888888888"
                        },
                        new
                        {
                            Id = 12,
                            FechaNacimiento = new DateTime(1997, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Isabel",
                            Telefono = "666666666"
                        },
                        new
                        {
                            Id = 13,
                            FechaNacimiento = new DateTime(1989, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Roberto",
                            Telefono = "222222222"
                        },
                        new
                        {
                            Id = 14,
                            FechaNacimiento = new DateTime(2001, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Natalia",
                            Telefono = "111111111"
                        },
                        new
                        {
                            Id = 15,
                            FechaNacimiento = new DateTime(1983, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Andres",
                            Telefono = "444444444"
                        },
                        new
                        {
                            Id = 16,
                            FechaNacimiento = new DateTime(1994, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Carmen",
                            Telefono = "555555555"
                        },
                        new
                        {
                            Id = 17,
                            FechaNacimiento = new DateTime(1999, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Gabriel",
                            Telefono = "777777777"
                        },
                        new
                        {
                            Id = 18,
                            FechaNacimiento = new DateTime(2003, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Beatriz",
                            Telefono = "123456789"
                        },
                        new
                        {
                            Id = 19,
                            FechaNacimiento = new DateTime(1986, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Alejandro",
                            Telefono = "987654321"
                        },
                        new
                        {
                            Id = 20,
                            FechaNacimiento = new DateTime(1991, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombre = "Silvia",
                            Telefono = "999999999"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
