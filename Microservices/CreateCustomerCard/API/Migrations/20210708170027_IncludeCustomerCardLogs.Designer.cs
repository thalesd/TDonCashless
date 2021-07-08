﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TDonCashless.Microservices.CreateCustomerCard.Data.Context;

namespace TDonCashless.Microservices.CreateCustomerCard.API.Migrations
{
    [DbContext(typeof(CustomerCardDbContext))]
    [Migration("20210708170027_IncludeCustomerCardLogs")]
    partial class IncludeCustomerCardLogs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TDonCashless.Microservices.CreateCustomerCard.Domain.Models.CustomerCard", b =>
                {
                    b.Property<int>("CustomerCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<long>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Token")
                        .HasColumnType("bigint");

                    b.HasKey("CustomerCardId");

                    b.ToTable("CustomerCards");
                });

            modelBuilder.Entity("TDonCashless.Microservices.CreateCustomerCard.Domain.Models.CustomerCardLog", b =>
                {
                    b.Property<int>("CustomerCardLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<long>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("CustomerCardId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Token")
                        .HasColumnType("bigint");

                    b.HasKey("CustomerCardLogId");

                    b.ToTable("CustomerCardLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
