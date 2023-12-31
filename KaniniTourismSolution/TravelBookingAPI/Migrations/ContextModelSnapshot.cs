﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelBookingAPI.Models;

#nullable disable

namespace TravelBookingAPI.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TravelBookingAPI.Models.OTravellers", b =>
                {
                    b.Property<int>("OtherTravellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtherTravellerId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<int?>("packageId")
                        .HasColumnType("int");

                    b.Property<string>("travellerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OtherTravellerId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Tour_Travellers");
                });

            modelBuilder.Entity("TravelBookingAPI.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"), 1L, 1);

                    b.Property<int?>("AgencyId")
                        .HasColumnType("int");

                    b.Property<string>("Drop")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PickUp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TravellerCount")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("availableCount")
                        .HasColumnType("int");

                    b.Property<int>("packageId")
                        .HasColumnType("int");

                    b.Property<string>("travellerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TravelBookingAPI.Models.OTravellers", b =>
                {
                    b.HasOne("TravelBookingAPI.Models.Reservation", "reservation")
                        .WithMany("passengers")
                        .HasForeignKey("ReservationId");

                    b.Navigation("reservation");
                });

            modelBuilder.Entity("TravelBookingAPI.Models.Reservation", b =>
                {
                    b.Navigation("passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
