﻿// <auto-generated />
using EntityFrameWorkOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameWorkOne.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190807131831_Added foreign key")]
    partial class Addedforeignkey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameWorkOne.Models.Major", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("MinSAT");

                    b.HasKey("Id");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("EntityFrameWorkOne.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("GPA");

                    b.Property<bool>("IsFulltime");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("SAT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
