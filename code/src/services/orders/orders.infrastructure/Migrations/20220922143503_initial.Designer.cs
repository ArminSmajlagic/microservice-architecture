﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using orders.infrastructure.persistence;

#nullable disable

namespace orders.infrastructure.Migrations
{
    [DbContext(typeof(OrdersContext))]
    [Migration("20220922143503_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("orders.domain.entities.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<DateTime>("created")
                        .HasColumnType("datetime2");

                    b.Property<string>("created_by")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("modifed")
                        .HasColumnType("datetime2");

                    b.Property<string>("modified_by")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("payment_id")
                        .HasColumnType("int");

                    b.Property<decimal>("total_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("orders");
                });
#pragma warning restore 612, 618
        }
    }
}
