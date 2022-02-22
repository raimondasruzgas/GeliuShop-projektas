﻿// <auto-generated />
using GeliuEshop_projektas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeliuEshop_projektas.Migrations
{
    [DbContext(typeof(GeliuEshopDbContext))]
    [Migration("20220222185502_preke")]
    partial class preke
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GeliuEshop_projektas.Models.Preke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aprasymas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Kaina")
                        .HasColumnType("float");

                    b.Property<string>("Nuotrauka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vardas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Prekes");
                });
#pragma warning restore 612, 618
        }
    }
}
