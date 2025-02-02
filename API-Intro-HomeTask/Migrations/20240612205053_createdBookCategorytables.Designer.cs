﻿// <auto-generated />
using System;
using API_Intro_HomeTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Intro_HomeTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240612205053_createdBookCategorytables")]
    partial class createdBookCategorytables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_Intro_HomeTask.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(748),
                            Name = "Harry Potter",
                            Price = 121m
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(752),
                            Name = "Don Quixote",
                            Price = 140m
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(754),
                            Name = "In Search of Lost Time",
                            Price = 180m
                        });
                });

            modelBuilder.Entity("API_Intro_HomeTask.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categpries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(648),
                            Name = "UI UX"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(650),
                            Name = "Backend"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 6, 13, 0, 50, 53, 307, DateTimeKind.Local).AddTicks(651),
                            Name = "Frontend"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
