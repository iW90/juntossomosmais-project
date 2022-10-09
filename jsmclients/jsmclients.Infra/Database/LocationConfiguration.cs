﻿using jsmclients.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace jsmclients.Infra.Database
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");

            builder.HasKey(pk => pk.Id);

            builder.Property(p => p.Street)
                .HasColumnType("VARCHAR(255)");
            builder.Property(p => p.City)
                .HasColumnType("VARCHAR(50)");
            builder.Property(p => p.State)
                .HasColumnType("VARCHAR(50)");
            builder.Property(p => p.Postcode)
                .HasColumnType("INT");
            builder.Property(p => p.Latitude)
                .HasColumnType("CHAR(11)");
            builder.Property(p => p.Longitude)
                .HasColumnType("CHAR(11)");
            builder.Property(p => p.TimezoneOffset)
                .HasColumnType("CHAR(6)");
            builder.Property(p => p.TimezoneDescription)
                .HasColumnType("VARCHAR(255)");
        }
    }
}