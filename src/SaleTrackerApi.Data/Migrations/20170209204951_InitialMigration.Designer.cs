using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SaleTrackerApi.Data;

namespace SaleTrackerApi.Data.Migrations
{
    [DbContext(typeof(SaleTrackerContext))]
    [Migration("20170209204951_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Street");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Price");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateTime");

                    b.Property<int?>("StoreId");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.SalesLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ItemId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("SaleId");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.HasIndex("SaleId");

                    b.ToTable("SalesLineItems");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.Sale", b =>
                {
                    b.HasOne("SaleTrackerApi.Data.Entities.Store")
                        .WithMany("Sales")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.SalesLineItem", b =>
                {
                    b.HasOne("SaleTrackerApi.Data.Entities.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");

                    b.HasOne("SaleTrackerApi.Data.Entities.Sale")
                        .WithMany("Items")
                        .HasForeignKey("SaleId");
                });

            modelBuilder.Entity("SaleTrackerApi.Data.Entities.Store", b =>
                {
                    b.HasOne("SaleTrackerApi.Data.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
        }
    }
}
