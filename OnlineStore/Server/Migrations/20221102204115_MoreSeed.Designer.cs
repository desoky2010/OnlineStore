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
    [Migration("20221102204115_MoreSeed")]
    partial class MoreSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineStore.Shared.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "electric machines",
                            URL = "electric-machines"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books",
                            URL = "books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electronics",
                            URL = "electronics"
                        });
                });

            modelBuilder.Entity("OnlineStore.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

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

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Amazon Basics Stainless Steel Portable Fast, Electric Hot Water Kettle for Tea and Coffee - 1 Liter, Gray/Black",
                            ImgURL = "https://m.media-amazon.com/images/I/91oiSVwU7OL._AC_SL1500_.jpg",
                            Price = 45.0,
                            Title = "Electric Hot Water Kettle"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "FAVIA Electric Kettle Water Boiler for Boiling Hot Water 1.7L with Wide Opening Auto Shut-Off & Boil-Dry Protection Tea Kettle Glass Pot Cordless LED Indicator 1500W BPA Free",
                            ImgURL = "https://m.media-amazon.com/images/I/710DlgQWe-L._AC_SL1500_.jpg",
                            Price = 90.0,
                            Title = "FAVIA Electric Kettle Water"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Electric Tea Kettle, Retro Electric Hot Water Kettle, 1350w Quick Boil, Thermometer Dial, Auto Shut-Off and Boil-Dry Protection, Portable Instant Heater for Making Tea, Coffee\r\n",
                            ImgURL = "https://m.media-amazon.com/images/I/61qQ5LmhDdL._AC_SL1500_.jpg",
                            Price = 70.989999999999995,
                            Title = "Electric Tea Kettle"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Echo Dot (3rd Gen, 2018 release) - Smart speaker with Alexa - Charcoal",
                            ImgURL = "https://m.media-amazon.com/images/I/6182S7MYC2L._AC_SL1000_.jpg",
                            Price = 19.989999999999998,
                            Title = "Smart speaker"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Echo Show 8 (2nd Gen, 2021 release) | HD smart display with Alexa and 13 MP camera | Charcoal",
                            ImgURL = "https://m.media-amazon.com/images/I/51yQll2L7xL._AC_SL1000_.jpg",
                            Price = 160.0,
                            Title = "smart display"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Sixteen-year-old Frankie Budge—aspiring writer, indifferent student, offbeat loner—is determined to make it through yet another sad summer in Coalfield, Tennessee, when she meets Zeke, a talented artist who has just moved into his grandmother’s unhappy house and who is as lonely and awkward as Frankie is. Romantic and creative sparks begin to fly, and when the two jointly make an unsigned poster, shot through with an enigmatic phrase, it becomes unforgettable to anyone who sees it. The edge is a shantytown filled with gold seekers. We are fugitives, and the law is skinny with hunger for us.\r\n\r\nThe posters begin appearing everywhere, and people wonder who is behind them. Satanists, kidnappers—the rumors won’t stop, and soon the mystery has dangerous repercussions that spread far beyond the town. The art that brought Frankie and Zeke together now threatens to tear them apart.\r\n\r\nTwenty years later, Frances Eleanor Budge—famous author, mom to a wonderful daughter, wife to a loving husband—gets a call that threatens to upend everything: a journalist named Mazzy Brower is writing a story about the Coalfield Panic of 1996. Might Frances know something about that? And will what she knows destroy the life she’s so carefully built?\r\n\r\nA bold coming-of-age story, written with Kevin Wilson’s trademark wit and blazing prose, Now Is Not The Time to Panic is a nuanced exploration of young love, identity, and the power of art. It’s also about the secrets that haunt us—and, ultimately, what the truth will set free.",
                            ImgURL = "https://m.media-amazon.com/images/I/517JPB71DyL.jpg",
                            Price = 9.0,
                            Title = "Now Is Not the Time to Panic"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Whether we love them or hate them, think they’re sexy, think they’re strange, consider them too big, too small, or anywhere in between, humans have a complicated relationship with butts. It is a body part unique to humans, critical to our evolution and survival, and yet it has come to signify so much more: sex, desire, comedy, shame. A woman’s butt, in particular, is forever being assessed, criticized, and objectified, from anxious self-examinations trying on jeans in department store dressing rooms to enduring crass remarks while walking down a street or high school hallways. But why? In Butts: A Backstory, reporter, essayist, and RadioLab contributing editor Heather Radke is determined to find out.\r\n\r\nSpanning nearly two centuries, this “whip-smart” (Publishers Weekly, starred review) cultural history takes us from the performance halls of 19th-century London to the aerobics studios of the 1980s, the music video set of Sir Mix-a-Lot’s “Baby Got Back” and the mountains of Arizona, where every year humans and horses race in a feat of gluteal endurance. Along the way, she meets evolutionary biologists who study how butts first developed; models whose measurements have defined jean sizing for millions of women; and the fitness gurus who created fads like “Buns of Steel.” She also examines the central importance of race through figures like Sarah Bartmann, once known as the “Venus Hottentot,” Josephine Baker, Jennifer Lopez, and other women of color whose butts have been idolized, envied, and despised.\r\n\r\nPart deep dive reportage, part personal journey, part cabinet of curiosities, Butts is an entertaining, illuminating, and thoughtful examination of why certain silhouettes come in and out of fashion—and how larger ideas about race, control, liberation, and power affect our most private feelings about ourselves and others.",
                            ImgURL = "https://m.media-amazon.com/images/I/31ntk3LZQyL.jpg",
                            Price = 20.0,
                            Title = "Butts: A Backstory"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "REDMOND 4 Slice Toaster Retro Stainless Steel Toasters with Bagel Defrost Cancel Function, 6 Browning Settings, Cream, ST033",
                            ImgURL = "https://m.media-amazon.com/images/I/71cZBKs+kGL._AC_SL1500_.jpg",
                            Price = 59.0,
                            Title = "REDMOND"
                        });
                });

            modelBuilder.Entity("OnlineStore.Shared.Models.Product", b =>
                {
                    b.HasOne("OnlineStore.Shared.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
