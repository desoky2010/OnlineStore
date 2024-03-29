﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Server.Data;

#nullable disable

namespace OnlineStore.Server.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221102183656_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineStore.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Amazon Basics Stainless Steel Portable Fast, Electric Hot Water Kettle for Tea and Coffee - 1 Liter, Gray/Black",
                            ImgURL = "https://m.media-amazon.com/images/I/91oiSVwU7OL._AC_SL1500_.jpg",
                            Price = 45.0,
                            Title = "Electric Hot Water Kettle"
                        },
                        new
                        {
                            Id = 2,
                            Description = "FAVIA Electric Kettle Water Boiler for Boiling Hot Water 1.7L with Wide Opening Auto Shut-Off & Boil-Dry Protection Tea Kettle Glass Pot Cordless LED Indicator 1500W BPA Free",
                            ImgURL = "https://m.media-amazon.com/images/I/710DlgQWe-L._AC_SL1500_.jpg",
                            Price = 90.0,
                            Title = "FAVIA Electric Kettle Water"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Electric Tea Kettle, Retro Electric Hot Water Kettle, 1350w Quick Boil, Thermometer Dial, Auto Shut-Off and Boil-Dry Protection, Portable Instant Heater for Making Tea, Coffee\r\n",
                            ImgURL = "https://m.media-amazon.com/images/I/61qQ5LmhDdL._AC_SL1500_.jpg",
                            Price = 70.989999999999995,
                            Title = "Electric Tea Kettle"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
