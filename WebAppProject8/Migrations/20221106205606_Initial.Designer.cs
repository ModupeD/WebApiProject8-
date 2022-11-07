﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAppProject8.Data;

#nullable disable

namespace WebAppProject8.Migrations
{
    [DbContext(typeof(FootballTeamsContext))]
    [Migration("20221106205606_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAppProject8.Models.FootballTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SuperbowlAppearances")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FootballTeams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Buffalo",
                            Name = "Bills",
                            SuperbowlAppearances = 4
                        },
                        new
                        {
                            Id = 2,
                            City = "San Francisco",
                            Name = "49ers",
                            SuperbowlAppearances = 6
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
