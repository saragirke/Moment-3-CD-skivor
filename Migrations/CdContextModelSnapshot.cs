﻿// <auto-generated />
using System;
using CdSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CdSite.Migrations
{
    [DbContext(typeof(CdContext))]
    partial class CdContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("CdSite.Models.Cd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cd");
                });

            modelBuilder.Entity("CdSite.Models.Lending", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BorrowerName")
                        .HasColumnType("TEXT");

                    b.Property<int>("CdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CdId");

                    b.ToTable("Lending");
                });

            modelBuilder.Entity("CdSite.Models.Lending", b =>
                {
                    b.HasOne("CdSite.Models.Cd", "Cd")
                        .WithMany()
                        .HasForeignKey("CdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cd");
                });
#pragma warning restore 612, 618
        }
    }
}
