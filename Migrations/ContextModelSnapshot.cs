﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelProject.Data;

#nullable disable

namespace TravelProject.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("TravelProject.Models.Activities", b =>
                {
                    b.Property<int>("IdActivity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("IdActivity");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("TravelProject.Models.Rentals", b =>
                {
                    b.Property<int>("IdRentals")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Fee")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rentalname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Party")
                        .HasColumnType("TEXT");

                    b.HasKey("IdRentals");

                    b.ToTable("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}
