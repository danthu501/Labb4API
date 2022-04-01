﻿// <auto-generated />
using System;
using Labb4API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb4API.Migrations
{
    [DbContext(typeof(Labb4APIDbContext))]
    [Migration("20220323093012_RemovedPeopleIntInInterest")]
    partial class RemovedPeopleIntInInterest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb4API.Models.Interest", b =>
                {
                    b.Property<int>("IntrestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PeopleId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntrestId");

                    b.HasIndex("PeopleId");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Labb4API.Models.Link", b =>
                {
                    b.Property<string>("LinksId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("InterestIntrestId")
                        .HasColumnType("int");

                    b.Property<string>("LinkAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("LinksId");

                    b.HasIndex("InterestIntrestId");

                    b.HasIndex("PeopleId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("Labb4API.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Peoples");
                });

            modelBuilder.Entity("Labb4API.Models.Interest", b =>
                {
                    b.HasOne("Labb4API.Models.People", null)
                        .WithMany("Interests")
                        .HasForeignKey("PeopleId");
                });

            modelBuilder.Entity("Labb4API.Models.Link", b =>
                {
                    b.HasOne("Labb4API.Models.Interest", "Interest")
                        .WithMany("Links")
                        .HasForeignKey("InterestIntrestId");

                    b.HasOne("Labb4API.Models.People", "People")
                        .WithMany("Links")
                        .HasForeignKey("PeopleId");
                });
#pragma warning restore 612, 618
        }
    }
}