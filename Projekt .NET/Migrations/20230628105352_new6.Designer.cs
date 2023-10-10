﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_.NET.Context;

#nullable disable

namespace Projekt_.NET.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20230628105352_new6")]
    partial class new6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projekt_.NET.DTO.AlbumDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RelaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AlbumDto");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoData")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RelaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DistributorId");

                    b.HasIndex("ProducerId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Album_Performer", b =>
                {
                    b.Property<int>("PerformerId")
                        .HasColumnType("int");

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.HasKey("PerformerId", "AlbumId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Album_Performers", (string)null);
                });

            modelBuilder.Entity("Projekt_.NET.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rap & Hip-Hop"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rap & Hip-Hop2"
                        });
                });

            modelBuilder.Entity("Projekt_.NET.Models.Distributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Distributors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sony Music Entertainment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Universal Music Polska"
                        });
                });

            modelBuilder.Entity("Projekt_.NET.Models.Performer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Performers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Travis Scott"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Juice WRLD"
                        });
                });

            modelBuilder.Entity("Projekt_.NET.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sony Music Entertainment"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Universal Music Group"
                        });
                });

            modelBuilder.Entity("Projekt_.NET.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "AQAAAAIAAYagAAAAECI4J0+GRyFS4lpvu51BKprBUWbbqqJRSCGPFI+a3iqz55NzqPs0MLB/hYbOFKEFSQ==",
                            Role = "admin",
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Password = "AQAAAAIAAYagAAAAECJaf8AH+ljXgmB+KpvNANG0K0mqO7WxRPz2LRVNJOcSw20vVSYGxGunovySx1tLuA==",
                            Role = "user",
                            Username = "user"
                        },
                        new
                        {
                            Id = 3,
                            Password = "AQAAAAIAAYagAAAAEPTexRyp7PcBbOi77O0IZRYyWp6gSa9GWU11tZqMuftwYmzMnNUC822KogT2/0AZpg==",
                            Role = "moderator",
                            Username = "moderator"
                        });
                });

            modelBuilder.Entity("Projekt_.NET.Models.Album", b =>
                {
                    b.HasOne("Projekt_.NET.Models.Category", "Category")
                        .WithMany("Albums")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_.NET.Models.Distributor", "Distributor")
                        .WithMany("Albums")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_.NET.Models.Producer", "Producer")
                        .WithMany("Albums")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Distributor");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Album_Performer", b =>
                {
                    b.HasOne("Projekt_.NET.Models.Album", "Album")
                        .WithMany("Performers")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_.NET.Models.Performer", "Performer")
                        .WithMany("Albums")
                        .HasForeignKey("PerformerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Performer");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Album", b =>
                {
                    b.Navigation("Performers");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Category", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Distributor", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Performer", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("Projekt_.NET.Models.Producer", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
