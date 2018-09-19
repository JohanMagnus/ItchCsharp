﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Samuraj;

namespace Samuraj.Migrations
{
    [DbContext(typeof(SamuraiContext))]
    [Migration("20180911090645_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Samuraj.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuoteText");

                    b.Property<int?>("SamuraiId");

                    b.Property<int>("StyleOfQoute");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quote");
                });

            modelBuilder.Entity("Samuraj.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("Samuraj.Quote", b =>
                {
                    b.HasOne("Samuraj.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId");
                });
#pragma warning restore 612, 618
        }
    }
}