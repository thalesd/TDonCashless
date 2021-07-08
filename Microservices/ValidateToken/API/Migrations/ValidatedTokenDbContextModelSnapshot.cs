﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TDonCashless.Microservices.ValidateToken.Data.Context;

namespace TDonCashless.Microservices.ValidateToken.API.Migrations
{
    [DbContext(typeof(ValidatedTokenDbContext))]
    partial class ValidatedTokenDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TDonCashless.Microservices.ValidateToken.Domain.Models.ValidatedToken", b =>
                {
                    b.Property<int>("ValidatedTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<long>("Token")
                        .HasColumnType("bigint");

                    b.Property<bool>("Valid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ValidatedLogTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ValidatedTokenId");

                    b.ToTable("ValidatedTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
