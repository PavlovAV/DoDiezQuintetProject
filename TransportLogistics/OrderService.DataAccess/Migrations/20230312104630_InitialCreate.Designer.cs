﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderService.DataAccess.Models;

#nullable disable

namespace OrderService.DataAccess.Migrations
{
    [DbContext(typeof(AppFactory))]
    [Migration("20230312104630_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrderService.DataAccess.Models.OrdersDb", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PointOfDepartureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PointOfDestinationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PointOfDepartureId");

                    b.HasIndex("PointOfDestinationId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("TransportLogistics.Domain.Models.Order.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("UnitDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<int>("Widtht")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ordersLine");
                });

            modelBuilder.Entity("TransportLogistics.Domain.Models.Points.Point", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("point");
                });

            modelBuilder.Entity("OrderService.DataAccess.Models.OrdersDb", b =>
                {
                    b.HasOne("TransportLogistics.Domain.Models.Points.Point", "PointOfDeparture")
                        .WithMany()
                        .HasForeignKey("PointOfDepartureId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TransportLogistics.Domain.Models.Points.Point", "PointOfDestination")
                        .WithMany()
                        .HasForeignKey("PointOfDestinationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("PointOfDeparture");

                    b.Navigation("PointOfDestination");
                });
#pragma warning restore 612, 618
        }
    }
}