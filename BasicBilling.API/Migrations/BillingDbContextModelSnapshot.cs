﻿// <auto-generated />
using BasicBilling.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BasicBilling.API.Migrations
{
    [DbContext(typeof(BillingDbContext))]
    partial class BillingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("BasicBilling.Data.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Period")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Bills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "WATER",
                            Period = 202209
                        },
                        new
                        {
                            Id = 2,
                            Category = "ELECTRICITY",
                            Period = 202210
                        });
                });

            modelBuilder.Entity("BasicBilling.Data.Billing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int>("BillId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ClientId");

                    b.ToTable("Billings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 65.200000000000003,
                            BillId = 1,
                            ClientId = 100,
                            State = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 165.90000000000001,
                            BillId = 2,
                            ClientId = 100,
                            State = "Paid"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 35.0,
                            BillId = 1,
                            ClientId = 200,
                            State = "Paid"
                        },
                        new
                        {
                            Id = 4,
                            Amount = 270.0,
                            BillId = 2,
                            ClientId = 200,
                            State = "Pending"
                        },
                        new
                        {
                            Id = 5,
                            Amount = 84.5,
                            BillId = 1,
                            ClientId = 300,
                            State = "Paid"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 15.0,
                            BillId = 2,
                            ClientId = 300,
                            State = "Paid"
                        },
                        new
                        {
                            Id = 7,
                            Amount = 87.299999999999997,
                            BillId = 1,
                            ClientId = 400,
                            State = "Pending"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 94.099999999999994,
                            BillId = 2,
                            ClientId = 400,
                            State = "Paid"
                        },
                        new
                        {
                            Id = 9,
                            Amount = 100.0,
                            BillId = 1,
                            ClientId = 500,
                            State = "Paid"
                        },
                        new
                        {
                            Id = 10,
                            Amount = 61.700000000000003,
                            BillId = 2,
                            ClientId = 500,
                            State = "Pending"
                        });
                });

            modelBuilder.Entity("BasicBilling.Data.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Name = "Joseph Carlton"
                        },
                        new
                        {
                            Id = 200,
                            Name = "Maria Juarez"
                        },
                        new
                        {
                            Id = 300,
                            Name = "Albert Kenny"
                        },
                        new
                        {
                            Id = 400,
                            Name = "Jessica Philips"
                        },
                        new
                        {
                            Id = 500,
                            Name = "Charles Johnson"
                        });
                });

            modelBuilder.Entity("BasicBilling.Data.Billing", b =>
                {
                    b.HasOne("BasicBilling.Data.Bill", "BillDetails")
                        .WithMany()
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BasicBilling.Data.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillDetails");

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
