﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jsmclients.Infra.Database;

namespace jsmclients.Infra.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221010172432_ClientRegistries")]
    partial class ClientRegistries
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("jsmclients.Core.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cel")
                        .HasColumnType("CHAR(20)");

                    b.Property<DateTime>("DobDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("FirstName")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Gender")
                        .HasColumnType("CHAR(1)");

                    b.Property<int>("IdLocation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdPicture")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Nationality")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("CHAR(2)")
                        .HasDefaultValue("BR");

                    b.Property<string>("Phone")
                        .HasColumnType("CHAR(20)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("TitleName")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdLocation")
                        .IsUnique();

                    b.HasIndex("IdPicture")
                        .IsUnique();

                    b.ToTable("Client");
                });

            modelBuilder.Entity("jsmclients.Core.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Latitude")
                        .HasColumnType("CHAR(11)");

                    b.Property<string>("Longitude")
                        .HasColumnType("CHAR(11)");

                    b.Property<int>("Postcode")
                        .HasColumnType("INT");

                    b.Property<int>("Region")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Street")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("TimezoneDescription")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("TimezoneOffset")
                        .HasColumnType("CHAR(6)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("jsmclients.Core.Entities.Pictures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Large")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Medium")
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("VARCHAR(255)");

                    b.HasKey("Id");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("jsmclients.Core.Entities.Client", b =>
                {
                    b.HasOne("jsmclients.Core.Entities.Location", "Location")
                        .WithOne("Client")
                        .HasForeignKey("jsmclients.Core.Entities.Client", "IdLocation")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("jsmclients.Core.Entities.Pictures", "Pictures")
                        .WithOne("Client")
                        .HasForeignKey("jsmclients.Core.Entities.Client", "IdPicture")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("jsmclients.Core.Entities.Location", b =>
                {
                    b.Navigation("Client");
                });

            modelBuilder.Entity("jsmclients.Core.Entities.Pictures", b =>
                {
                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}