﻿// <auto-generated />
using System;
using AspNetCoremMvcDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoremMvcDepartman.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoremMvcDepartman.Models.Departman", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmanAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departmans");
                });

            modelBuilder.Entity("AspNetCoremMvcDepartman.Models.Personel", b =>
                {
                    b.Property<int>("PerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PerAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerSehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PerSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departID")
                        .HasColumnType("int");

                    b.HasKey("PerID");

                    b.HasIndex("departID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("AspNetCoremMvcDepartman.Models.Personel", b =>
                {
                    b.HasOne("AspNetCoremMvcDepartman.Models.Departman", "depart")
                        .WithMany("personels")
                        .HasForeignKey("departID");

                    b.Navigation("depart");
                });

            modelBuilder.Entity("AspNetCoremMvcDepartman.Models.Departman", b =>
                {
                    b.Navigation("personels");
                });
#pragma warning restore 612, 618
        }
    }
}