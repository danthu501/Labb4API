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
    [Migration("20220328083510_Test2")]
    partial class Test2
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

                    b.Property<int>("InterestId")
                        .HasColumnType("int");

                    b.Property<string>("LinkAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PeopleId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("LinksId");

                    b.HasIndex("InterestId");

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
                    b.HasOne("Labb4API.Models.People", "People")
                        .WithMany("Interests")
                        .HasForeignKey("PeopleId");
                });

            modelBuilder.Entity("Labb4API.Models.Link", b =>
                {
                    b.HasOne("Labb4API.Models.Interest", "Interest")
                        .WithMany("Links")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb4API.Models.People", "People")
                        .WithMany("Links")
                        .HasForeignKey("PeopleId");
                });
#pragma warning restore 612, 618
        }
    }
}