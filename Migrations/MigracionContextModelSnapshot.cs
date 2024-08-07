﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Final.Models;

#nullable disable

namespace Proyecto_Final.Migrations
{
    [DbContext(typeof(MigracionContext))]
    partial class MigracionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Proyecto_Final.Models.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Codigo_Vital")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Dinero")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Fecha_Nacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Id_Redada")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Identificacion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<float>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Proyecto_Final.Models.Redada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("FechaRedada")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Responsable")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tipo_Vehiculo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Redadas");
                });
#pragma warning restore 612, 618
        }
    }
}
