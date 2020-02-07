﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SneakerRockMVC.Data;

namespace SneakerRock.Migrations
{
    [DbContext(typeof(SneakerRockDbContext))]
    [Migration("20200130230145_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SneakerRockMVC.Models.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("SneakerRockMVC.Models.BrandName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.ToTable("BrandNames");
                });

            modelBuilder.Entity("SneakerRockMVC.Models.Collection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DatePurchased")
                        .HasColumnType("int");

                    b.Property<int>("ShoeSize")
                        .HasColumnType("int");

                    b.Property<int>("SneakerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Collections");
                });

            modelBuilder.Entity("SneakerRockMVC.Models.ColorWay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StyleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("StyleID");

                    b.ToTable("Colorways");
                });

            modelBuilder.Entity("SneakerRockMVC.Models.Sneaker", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ColorWayID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ColorWayID");

                    b.ToTable("Sneakers");
                });

            modelBuilder.Entity("SneakerRockMVC.Models.Style", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandNameID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BrandNameID");

                    b.ToTable("Styles");
                });

            modelBuilder.Entity("SneakerRockMVC.Models.BrandName", b =>
                {
                    b.HasOne("SneakerRockMVC.Models.Brand", "Brand")
                        .WithMany("BrandNames")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SneakerRockMVC.Models.ColorWay", b =>
                {
                    b.HasOne("SneakerRockMVC.Models.Style", "Style")
                        .WithMany("ColorWays")
                        .HasForeignKey("StyleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SneakerRockMVC.Models.Sneaker", b =>
                {
                    b.HasOne("SneakerRockMVC.Models.ColorWay", "ColorWay")
                        .WithMany("Sneakers")
                        .HasForeignKey("ColorWayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SneakerRockMVC.Models.Style", b =>
                {
                    b.HasOne("SneakerRockMVC.Models.BrandName", "BrandName")
                        .WithMany("Styles")
                        .HasForeignKey("BrandNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}