﻿// <auto-generated />
using System;
using CamKyscn.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CamKyscn.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CamKyscn.Entities.Banda", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaqueteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaqueteId");

                    b.ToTable("Bandas");
                });

            modelBuilder.Entity("CamKyscn.Entities.Foto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ruta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruta_Demo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("paqueteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("paqueteId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("CamKyscn.Entities.Paquete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Paquetes");
                });

            modelBuilder.Entity("CamKyscn.Entities.Banda", b =>
                {
                    b.HasOne("CamKyscn.Entities.Paquete", null)
                        .WithMany("bandas")
                        .HasForeignKey("PaqueteId");
                });

            modelBuilder.Entity("CamKyscn.Entities.Foto", b =>
                {
                    b.HasOne("CamKyscn.Entities.Paquete", "paquete")
                        .WithMany()
                        .HasForeignKey("paqueteId");

                    b.Navigation("paquete");
                });

            modelBuilder.Entity("CamKyscn.Entities.Paquete", b =>
                {
                    b.Navigation("bandas");
                });
#pragma warning restore 612, 618
        }
    }
}
