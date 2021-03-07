﻿// <auto-generated />
using System;
using CamKyscn.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CamKyscn.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210307110256_AddBandasOTM")]
    partial class AddBandasOTM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CamKyscn.Entities.Banda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaqueteId")
                        .HasColumnType("int");

                    b.Property<string>("Ruta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruta_Demo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaqueteId");

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

                    b.Property<bool>("Comprado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Paquetes");
                });

            modelBuilder.Entity("CamKyscn.Entities.Banda", b =>
                {
                    b.HasOne("CamKyscn.Entities.Paquete", "Paquete")
                        .WithMany("Bandas")
                        .HasForeignKey("PaqueteId");

                    b.Navigation("Paquete");
                });

            modelBuilder.Entity("CamKyscn.Entities.Foto", b =>
                {
                    b.HasOne("CamKyscn.Entities.Paquete", null)
                        .WithMany("Fotos")
                        .HasForeignKey("PaqueteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CamKyscn.Entities.Paquete", b =>
                {
                    b.Navigation("Bandas");

                    b.Navigation("Fotos");
                });
#pragma warning restore 612, 618
        }
    }
}
