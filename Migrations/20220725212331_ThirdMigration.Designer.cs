﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelProject.Data;

#nullable disable

namespace TravelProject.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220725212331_ThirdMigration")]
    partial class ThirdMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.7");

            modelBuilder.Entity("TravelProject.Models.Activities", b =>
                {
                   b.Property<int>("idActivity")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("TEXT");

                   //b.Property<int?>("Id")
                   //.HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                 b.HasKey("idActivity");

                    b.ToTable("Activities");
                });
#pragma warning restore 612, 618
        }
    }
}
